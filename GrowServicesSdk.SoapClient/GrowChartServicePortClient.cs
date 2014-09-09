namespace GrowServicesSdk.SoapClient
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Channels;
    using System.Threading.Tasks;

    using GrowServicesSdk.SoapClient.Model;
    using GrowServicesSdk.SoapClient.Requests;
    using GrowServicesSdk.SoapClient.Responses;

    public class GrowChartServicePortClient : ClientBase<IGrowChartServicePort>, IGrowChartServicePort
    {
        #region Constructors and Destructors

        public GrowChartServicePortClient()
        {
        }

        public GrowChartServicePortClient(Uri webserviceUri)
            : base(webserviceUri.Scheme == "http" ? (Binding)new BasicHttpBinding() : new BasicHttpsBinding(), new EndpointAddress(webserviceUri))
        {
        }

        public GrowChartServicePortClient(string endpointConfigurationName)
            : base(endpointConfigurationName)
        {
        }

        public GrowChartServicePortClient(string endpointConfigurationName, string remoteAddress)
            : base(endpointConfigurationName, remoteAddress)
        {
        }

        public GrowChartServicePortClient(string endpointConfigurationName, EndpointAddress remoteAddress)
            : base(endpointConfigurationName, remoteAddress)
        {
        }

        public GrowChartServicePortClient(Binding binding, EndpointAddress remoteAddress)
            : base(binding, remoteAddress)
        {
        }

        #endregion

        public Authenticate AuthenticationInformation { get; set; }

        #region Public Methods and Operators

        public Measurement AddMeasurement(string growchartid, int date, string type, string value)
        {
            var inValue = new AddMeasurementRequest
                              {
                                  Authenticate = this.AuthenticationInformation,
                                  GrowchartId = growchartid,
                                  Date = date,
                                  Type = type,
                                  Value = value
                              };
            AddMeasurementResponse retVal = ((IGrowChartServicePort)(this)).AddMeasurement(inValue);
            return retVal.AddMeasurementResult;
        }

        public Task<AddMeasurementResponse> AddMeasurementAsync(string growchartid,int date,string type,string value)
        {
            var inValue = new AddMeasurementRequest
                              {
                                  Authenticate = this.AuthenticationInformation,
                                  GrowchartId = growchartid,
                                  Date = date,
                                  Type = type,
                                  Value = value
                              };
            return ((IGrowChartServicePort)(this)).AddMeasurementAsync(inValue);
        }

        public string ClearData(string growchartid)
        {
            var inValue = new ClearDataRequest { Authenticate = this.AuthenticationInformation, GrowchartId = growchartid };
            ClearDataResponse retVal = ((IGrowChartServicePort)(this)).ClearData(inValue);
            return retVal.Cleardataresult;
        }

        public Task<ClearDataResponse> ClearDataAsync(string growchartid)
        {
            var inValue = new ClearDataRequest { Authenticate = this.AuthenticationInformation, GrowchartId = growchartid };
            return ((IGrowChartServicePort)(this)).ClearDataAsync(inValue);
        }

        public GrowChartImage GetChartImage(string growchartid,string reference,float height,float width,string language,string firstname,string lastname,string maternaldob,string displayp95line,string gridlinebyweight,string grayscale)
        {
            var inValue = new GetChartImageRequest
                              {
                                  Authenticate = this.AuthenticationInformation,
                                  GrowchartId = growchartid,
                                  Reference = reference,
                                  Height = height,
                                  Width = width,
                                  Language = language,
                                  Firstname = firstname,
                                  Lastname = lastname,
                                  MaternalDob = maternaldob,
                                  Displayp95Line = displayp95line,
                                  GridlineByWeight = gridlinebyweight,
                                  Grayscale = grayscale
                              };
            GetChartImageResponse retVal = ((IGrowChartServicePort)(this)).GetChartImage(inValue);
            return retVal.GetChartImageResult;
        }

        public Task<GetChartImageResponse> GetChartImageAsync(string growchartid,string reference,float height,float width,string language,string firstname,string lastname,string maternaldob,string displayp95line,string gridlinebyweight,string grayscale)
        {
            var inValue = new GetChartImageRequest
                              {
                                  Authenticate = this.AuthenticationInformation,
                                  GrowchartId = growchartid,
                                  Reference = reference,
                                  Height = height,
                                  Width = width,
                                  Language = language,
                                  Firstname = firstname,
                                  Lastname = lastname,
                                  MaternalDob = maternaldob,
                                  Displayp95Line = displayp95line,
                                  GridlineByWeight = gridlinebyweight,
                                  Grayscale = grayscale
                              };
            return ((IGrowChartServicePort)(this)).GetChartImageAsync(inValue);
        }

        public CentileData GetData(string growchartid, string requiredate, float? weight)
        {
            var inValue = new GetDataRequest
                              {
                                  Authenticate = this.AuthenticationInformation,
                                  GrowchartId = growchartid,
                                  RequireDate = requiredate,
                                  Weight = weight
                              };
            GetDataResponse retVal = ((IGrowChartServicePort)(this)).GetData(inValue);
            return retVal.GetDataResult;
        }

        public Task<GetDataResponse> GetDataAsync(string growchartid,string requiredate,float? weight)
        {
            var inValue = new GetDataRequest
                              {
                                  Authenticate = this.AuthenticationInformation,
                                  GrowchartId = growchartid,
                                  RequireDate = requiredate,
                                  Weight = weight
                              };
            return ((IGrowChartServicePort)(this)).GetDataAsync(inValue);
        }

        public GrowChartPdf GetPdf(string growchartid,string firstname,string lastname,string maternaldob,string reference,string babyname,string babygender,float babygestation,float babybirthweight,string displayp95line,string gridlinebyweight,string grayscale)
        {
            var inValue = new GetPdfRequest
                              {
                                  Authenticate = this.AuthenticationInformation,
                                  GrowchartId = growchartid,
                                  Firstname = firstname,
                                  Lastname = lastname,
                                  MaternalDob = maternaldob,
                                  Reference = reference,
                                  BabyName = babyname,
                                  BabyGender = babygender,
                                  BabyGestation = babygestation,
                                  BabyBirthweight = babybirthweight,
                                  Displayp95Line = displayp95line,
                                  GridlineByWeight = gridlinebyweight,
                                  Grayscale = grayscale
                              };
            GetPdfResponse retVal = ((IGrowChartServicePort)(this)).GetPdf(inValue);
            return retVal.GetPdfResult;
        }

        public Task<GetPdfResponse> GetPdfAsync(string growchartid,string firstname,string lastname,string maternaldob,string reference,string babyname,string babygender,float babygestation,float babybirthweight,string displayp95line,string gridlinebyweight,string grayscale)
        {
            var inValue = new GetPdfRequest
                              {
                                  Authenticate = this.AuthenticationInformation,
                                  GrowchartId = growchartid,
                                  Firstname = firstname,
                                  Lastname = lastname,
                                  MaternalDob = maternaldob,
                                  Reference = reference,
                                  BabyName = babyname,
                                  BabyGender = babygender,
                                  BabyGestation = babygestation,
                                  BabyBirthweight = babybirthweight,
                                  Displayp95Line = displayp95line,
                                  GridlineByWeight = gridlinebyweight,
                                  Grayscale = grayscale
                              };
            return ((IGrowChartServicePort)(this)).GetPdfAsync(inValue);
        }

        public Pregnancy GetPregnancy(string growchartid)
        {
            var inValue = new GetPregnancyRequest { Authenticate = this.AuthenticationInformation, GrowchartId = growchartid };
            GetPregnancyResponse retVal = ((IGrowChartServicePort)(this)).GetPregnancy(inValue);
            return retVal.GetPregnancyResult;
        }

        public Task<GetPregnancyResponse> GetPregnancyAsync(string growchartid)
        {
            var inValue = new GetPregnancyRequest { Authenticate = this.AuthenticationInformation, GrowchartId = growchartid };
            return ((IGrowChartServicePort)(this)).GetPregnancyAsync(inValue);
        }

        public string RegisterBaby(string growchartid,int babynr,string babydob,string birthgestation,float birthweight,string babygender,string babyname,bool diagnosed,bool suspected,string previousgrowchartid)
        {
            var inValue = new RegisterBabyRequest
                              {
                                  Authenticate = this.AuthenticationInformation,
                                  GrowchartId = growchartid,
                                  BabyNr = babynr,
                                  BabyDob = babydob,
                                  BirthGestation = birthgestation,
                                  Birthweight = birthweight,
                                  Babygender = babygender,
                                  BabyName = babyname,
                                  Diagnosed = diagnosed,
                                  Suspected = suspected,
                                  PreviousGrowchartId = previousgrowchartid
                              };
            RegisterBabyResponse retVal = ((IGrowChartServicePort)(this)).RegisterBaby(inValue);
            return retVal.RegisterbabyResult;
        }

        public Task<RegisterBabyResponse> RegisterBabyAsync(string growchartid,int babynr,string babydob,string birthgestation,float birthweight,string babygender,string babyname,bool diagnosed,bool suspected,string previousgrowchartid)
        {
            var inValue = new RegisterBabyRequest
                              {
                                  Authenticate = this.AuthenticationInformation,
                                  GrowchartId = growchartid,
                                  BabyNr = babynr,
                                  BabyDob = babydob,
                                  BirthGestation = birthgestation,
                                  Birthweight = birthweight,
                                  Babygender = babygender,
                                  BabyName = babyname,
                                  Diagnosed = diagnosed,
                                  Suspected = suspected,
                                  PreviousGrowchartId = previousgrowchartid
                              };
            return ((IGrowChartServicePort)(this)).RegisterBabyAsync(inValue);
        }

        public string RegisterBirth(string growchartid,string babydob,float birthweight,string babygender,string antenataliugrdetection,bool suspected)
        {
            var inValue = new RegisterBirthRequest
                              {
                                  Authenticate = this.AuthenticationInformation,
                                  GrowchartId = growchartid,
                                  BabyDob = babydob,
                                  BirthWeight = birthweight,
                                  BabyGender = babygender,
                                  AntenataliugrDetection = antenataliugrdetection,
                                  Suspected = suspected
                              };
            RegisterBirthResponse retVal = ((IGrowChartServicePort)(this)).RegisterBirth(inValue);
            return retVal.RegisterBirthResult;
        }

        public Task<RegisterBirthResponse> RegisterBirthAsync(string growchartid,string babydob,float birthweight,string babygender,string antenataliugrdetection,bool suspected)
        {
            var inValue = new RegisterBirthRequest
                              {
                                  Authenticate = this.AuthenticationInformation,
                                  GrowchartId = growchartid,
                                  BabyDob = babydob,
                                  BirthWeight = birthweight,
                                  BabyGender = babygender,
                                  AntenataliugrDetection = antenataliugrdetection,
                                  Suspected = suspected
                              };
            return ((IGrowChartServicePort)(this)).RegisterBirthAsync(inValue);
        }

        public Pregnancy RegisterPregnancy(float maternalheight,float maternalweight,int ethnicity,int parity,int edd,string growversion,string growchartid,int? requestdate)
        {
            var inValue = new RegisterPregnancyRequest
                              {
                                  Authenticate = this.AuthenticationInformation,
                                  MaternalHeight = maternalheight,
                                  MaternalWeight = maternalweight,
                                  Ethnicity = ethnicity,
                                  Parity = parity,
                                  Edd = edd,
                                  GrowVersion = growversion,
                                  GrowchartId = growchartid,
                                  Requestdate = requestdate
                              };
            RegisterPregnancyResponse retVal = ((IGrowChartServicePort)(this)).RegisterPregnancy(inValue);
            return retVal.RegisterPregnancyResult;
        }

        public Task<RegisterPregnancyResponse> RegisterPregnancyAsync(float maternalheight,float maternalweight,int ethnicity,int parity,int edd,string growversion,string growchartid,int? requestdate)
        {
            var inValue = new RegisterPregnancyRequest
                              {
                                  Authenticate = this.AuthenticationInformation,
                                  MaternalHeight = maternalheight,
                                  MaternalWeight = maternalweight,
                                  Ethnicity = ethnicity,
                                  Parity = parity,
                                  Edd = edd,
                                  GrowVersion = growversion,
                                  GrowchartId = growchartid,
                                  Requestdate = requestdate
                              };
            return ((IGrowChartServicePort)(this)).RegisterPregnancyAsync(inValue);
        }

        public string RemoveMeasurement(string growchartid, string measurementuuid)
        {
            var inValue = new RemoveMeasurementRequest
                              {
                                  Authenticate = this.AuthenticationInformation,
                                  GrowchartId = growchartid,
                                  MeasurementUuid = measurementuuid
                              };
            RemoveMeasurementResponse retVal = ((IGrowChartServicePort)(this)).RemoveMeasurement(inValue);
            return retVal.RemoveMeasurementResult;
        }

        public Task<RemoveMeasurementResponse> RemoveMeasurementAsync(string growchartid,string measurementuuid)
        {
            var inValue = new RemoveMeasurementRequest
                              {
                                  Authenticate = this.AuthenticationInformation,
                                  GrowchartId = growchartid,
                                  MeasurementUuid = measurementuuid
                              };
            return ((IGrowChartServicePort)(this)).RemoveMeasurementAsync(inValue);
        }

        public Measurement UpdateMeasurement(string growchartid,string date,string type,float value,string uuid)
        {
            var inValue = new UpdateMeasurementRequest
                              {
                                  Authenticate = this.AuthenticationInformation,
                                  GrowchartId = growchartid,
                                  Date = date,
                                  Type = type,
                                  Value = value,
                                  Uuid = uuid
                              };
            UpdateMeasurementResponse retVal = ((IGrowChartServicePort)(this)).UpdateMeasurement(inValue);
            return retVal.UpdateMeasurementResult;
        }

        public Task<UpdateMeasurementResponse> UpdateMeasurementAsync(string growchartid,string date,string type,float value,string uuid)
        {
            var inValue = new UpdateMeasurementRequest
                              {
                                  Authenticate = this.AuthenticationInformation,
                                  GrowchartId = growchartid,
                                  Date = date,
                                  Type = type,
                                  Value = value,
                                  Uuid = uuid
                              };
            return ((IGrowChartServicePort)(this)).UpdateMeasurementAsync(inValue);
        }

        #endregion

        #region Explicit Interface Methods

        AddMeasurementResponse IGrowChartServicePort.AddMeasurement(AddMeasurementRequest request)
        {
            return base.Channel.AddMeasurement(request);
        }

        Task<AddMeasurementResponse> IGrowChartServicePort.AddMeasurementAsync(AddMeasurementRequest request)
        {
            return base.Channel.AddMeasurementAsync(request);
        }

        ClearDataResponse IGrowChartServicePort.ClearData(ClearDataRequest request)
        {
            return base.Channel.ClearData(request);
        }

        Task<ClearDataResponse> IGrowChartServicePort.ClearDataAsync(ClearDataRequest request)
        {
            return base.Channel.ClearDataAsync(request);
        }

        GetChartImageResponse IGrowChartServicePort.GetChartImage(GetChartImageRequest request)
        {
            return base.Channel.GetChartImage(request);
        }

        Task<GetChartImageResponse> IGrowChartServicePort.GetChartImageAsync(GetChartImageRequest request)
        {
            return base.Channel.GetChartImageAsync(request);
        }

        GetDataResponse IGrowChartServicePort.GetData(GetDataRequest request)
        {
            return base.Channel.GetData(request);
        }

        GetPdfResponse IGrowChartServicePort.GetPdf(GetPdfRequest request)
        {
            return base.Channel.GetPdf(request);
        }

        Task<GetPdfResponse> IGrowChartServicePort.GetPdfAsync(GetPdfRequest request)
        {
            return base.Channel.GetPdfAsync(request);
        }

        GetPregnancyResponse IGrowChartServicePort.GetPregnancy(GetPregnancyRequest request)
        {
            return base.Channel.GetPregnancy(request);
        }

        Task<GetPregnancyResponse> IGrowChartServicePort.GetPregnancyAsync(GetPregnancyRequest request)
        {
            return base.Channel.GetPregnancyAsync(request);
        }

        RegisterBabyResponse IGrowChartServicePort.RegisterBaby(RegisterBabyRequest request)
        {
            return base.Channel.RegisterBaby(request);
        }

        Task<RegisterBabyResponse> IGrowChartServicePort.RegisterBabyAsync(RegisterBabyRequest request)
        {
            return base.Channel.RegisterBabyAsync(request);
        }

        RegisterBirthResponse IGrowChartServicePort.RegisterBirth(RegisterBirthRequest request)
        {
            return base.Channel.RegisterBirth(request);
        }

        Task<RegisterBirthResponse> IGrowChartServicePort.RegisterBirthAsync(RegisterBirthRequest request)
        {
            return base.Channel.RegisterBirthAsync(request);
        }

        RegisterPregnancyResponse IGrowChartServicePort.RegisterPregnancy(RegisterPregnancyRequest request)
        {
            return base.Channel.RegisterPregnancy(request);
        }

        Task<RegisterPregnancyResponse> IGrowChartServicePort.RegisterPregnancyAsync(RegisterPregnancyRequest request)
        {
            return base.Channel.RegisterPregnancyAsync(request);
        }

        RemoveMeasurementResponse IGrowChartServicePort.RemoveMeasurement(RemoveMeasurementRequest request)
        {
            return base.Channel.RemoveMeasurement(request);
        }

        Task<RemoveMeasurementResponse> IGrowChartServicePort.RemoveMeasurementAsync(RemoveMeasurementRequest request)
        {
            return base.Channel.RemoveMeasurementAsync(request);
        }

        UpdateMeasurementResponse IGrowChartServicePort.UpdateMeasurement(UpdateMeasurementRequest request)
        {
            return base.Channel.UpdateMeasurement(request);
        }

        Task<UpdateMeasurementResponse> IGrowChartServicePort.UpdateMeasurementAsync(UpdateMeasurementRequest request)
        {
            return base.Channel.UpdateMeasurementAsync(request);
        }

        Task<GetDataResponse> IGrowChartServicePort.GetDataAsync(GetDataRequest request)
        {
            return base.Channel.GetDataAsync(request);
        }

        #endregion
    }
}