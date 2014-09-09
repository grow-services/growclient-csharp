namespace GrowServicesSdk.SoapClient.TestConsole
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ConsoleHelper
    {
        public static bool WordWrapEnabled = false;

        static readonly Func<FillTo, int> Width = f => f == FillTo.Buffer ? Console.BufferWidth - 1 : (Console.WindowWidth == Console.BufferWidth ? Console.WindowWidth - 1 : Console.WindowWidth);
        static readonly Func<int, int> AvailableWidth = width => width - Console.CursorLeft;
        static readonly Func<FillTo, int> AvailableWidthForFill = fillto => AvailableWidth(Width(fillto));
        static readonly Func<int, char, string> FillString = (count, c) => String.Join("", Enumerable.Range(0, Math.Abs(count)).Select(i => c));

        public static void Write(string text)
        {
            ReplaceTabs(ref text);
            Console.Write(text);
        }

        public static void WriteLine(string text = "", ConsoleAlign align = ConsoleAlign.Left, char fillChar = ' ', FillTo fillTo = FillTo.Window, string prefix = "")
        {
            ReplaceTabs(ref prefix);
            ReplaceTabs(ref text);

            if (IsRedirected())
            {
                Console.WriteLine(prefix + text);
                return;
            }

            foreach (var item in text.Split(new[] { "\r\n" }, StringSplitOptions.None))
                foreach (var chunk in item.Chunk(Width(fillTo), AvailableWidth(Width(fillTo)), prefix, !WordWrapEnabled))
                    WriteLineInternal(chunk, align, fillChar, fillTo, fillBufferIfFillToWindow: fillTo == FillTo.Window);
        }

        private static void WriteLineInternal(string text, ConsoleAlign align = ConsoleAlign.Left, char fillChar = ' ', FillTo fillTo = FillTo.Buffer, bool fillBufferIfFillToWindow = false)
        {
            var width = AvailableWidth(Width(fillTo));
            var widthToFill = width - text.Length;
            var widthToFillLeft = (align == ConsoleAlign.Center) ? widthToFill / 2 : (align == ConsoleAlign.Left ? 0 : widthToFill);
            var widthToFillRight = (align == ConsoleAlign.Center) ? widthToFill / 2 : (align == ConsoleAlign.Left ? widthToFill : 0);

            widthToFillRight = widthToFillRight + (widthToFill - widthToFillLeft - widthToFillRight);

            if (!fillBufferIfFillToWindow)
                Console.WriteLine(FillString(widthToFillLeft, fillChar) + text + FillString(widthToFillRight, fillChar));
            else
            {
                Console.Write(FillString(widthToFillLeft, fillChar) + text + FillString(widthToFillRight, fillChar));
                Console.WriteLine(FillString(AvailableWidthForFill(FillTo.Buffer) - AvailableWidthForFill(FillTo.Window), fillChar));
            }
        }

        private static void ReplaceTabs(ref string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return;

            text = text.Replace("\t", "    ");
        }

        private static bool IsRedirected()
        {
            bool isRedirected;

            try
            {
                isRedirected = Console.CursorVisible && false;
            }
            catch
            {
                isRedirected = true;
            }

            return isRedirected;
        }
    }

    public class ConsoleOptionChanger : IDisposable
    {
        public ConsoleColor OriginalForeColor { get; set; }
        public ConsoleColor OriginalBackColor { get; set; }
        public bool WordWrap { get; set; }
        public bool RestorePosition { get; set; }
        public int OriginalTop { get; set; }
        public int OriginalLeft { get; set; }

        public static ConsoleOptionChanger CreateWithOptions(ConsoleColor? foreground = null, ConsoleColor? background = null, bool? wordWrap = null, bool restorePosition = false)
        {
            var options = new ConsoleOptionChanger
                              {
                                  OriginalBackColor = Console.BackgroundColor,
                                  OriginalForeColor = Console.ForegroundColor,
                                  WordWrap = wordWrap.GetValueOrDefault(ConsoleHelper.WordWrapEnabled),
                                  RestorePosition = restorePosition
                              };

            if (restorePosition)
            {
                options.OriginalLeft = Console.WindowLeft;
                options.OriginalTop = Console.WindowTop;
            }

            Console.BackgroundColor = background.GetValueOrDefault(Console.BackgroundColor);
            Console.ForegroundColor = foreground.GetValueOrDefault(Console.ForegroundColor);

            return options;
        }

        public void Dispose()
        {
            Console.BackgroundColor = this.OriginalBackColor;
            Console.ForegroundColor = this.OriginalForeColor;

            ConsoleHelper.WordWrapEnabled = this.WordWrap;

            if (this.RestorePosition)
                Console.SetWindowPosition(this.OriginalLeft, this.OriginalTop);
        }
    }

    public enum ConsoleAlign
    {
        Left,
        Center,
        Right
    }

    public enum FillTo
    {
        Window,
        Buffer
    }

    public static class Ext
    {
        public static IEnumerable<string> Chunk(this string source, int chunkSize, int? firstChunkSize = null, string prefix = "", bool onlyKeepFirst = false)
        {
            var sourceAndPrefix = prefix + source;

            if (sourceAndPrefix.Length <= firstChunkSize.GetValueOrDefault(chunkSize))
            {
                yield return sourceAndPrefix;
                yield break;
            }

            if (onlyKeepFirst)
            {
                var normalValueToReturn = sourceAndPrefix.Substring(0, firstChunkSize.GetValueOrDefault(chunkSize));
                yield return normalValueToReturn.Insert(normalValueToReturn.Length - 3, "...").Substring(0, normalValueToReturn.Length);
                yield break;
            }
            else
                yield return sourceAndPrefix.Substring(0, firstChunkSize.GetValueOrDefault(chunkSize));

            source = sourceAndPrefix.Substring(firstChunkSize.GetValueOrDefault(chunkSize));
            chunkSize -= prefix.Length;

            int numberOfChunks = (int)Math.Ceiling((double)source.Length / chunkSize);

            for (int i = 0; i < numberOfChunks; i++)
            {
                //last loop
                if (i == (numberOfChunks - 1))
                    yield return prefix + source.Substring(i * chunkSize);
                else
                    yield return prefix + source.Substring(i * chunkSize, chunkSize);
            }
        }

        public static IEnumerable<string> Chunkv2(this string source, int chunkSize, int? firstChunkSize = null, string prefix = "", bool onlyKeepFirst = false)
        {
            Func<string, string> addPrefix = t => { if (!string.IsNullOrWhiteSpace(prefix)) return prefix + t; else return t; };
            firstChunkSize = firstChunkSize ?? 0;
            chunkSize -= prefix.Length;

            var numberOfChunks = (int)Math.Floor((double)(source.Length - firstChunkSize.Value) / chunkSize);

            var enumerableChunks = Enumerable.Concat(new int[] { firstChunkSize.Value }, Enumerable.Range(0, numberOfChunks).Select(i => chunkSize)).Concat(new int[] { source.Length - firstChunkSize.Value - (chunkSize * numberOfChunks) }).ToList()
                .Where(chunk => chunk > 0)
                .Select((chunk, i) => addPrefix(source.Substring(i == 0 ? i : (i * chunkSize) + firstChunkSize.Value, chunk)));

            return onlyKeepFirst ? new[] { enumerableChunks.FirstOrDefault() } : enumerableChunks;
        }
    }
}
