namespace GrowServicesSdk.SoapClient
{
    using System.ServiceModel;
    using System.Threading.Tasks;

    using GrowServicesSdk.SoapClient.Requests;
    using GrowServicesSdk.SoapClient.Responses;

    [ServiceContract(Namespace = "http://www.grow-services.net/api/grow/soap/", ConfigurationName = "ServiceReference1.GROWChartServicePort")]
    public interface IGrowChartServicePort
    {
        [OperationContract(Action = "http://www.grow-services.net/api/grow/soap/#addMeasurement", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        AddMeasurementResponse AddMeasurement(AddMeasurementRequest request);

        [OperationContract(Action = "http://www.grow-services.net/api/grow/soap/#addMeasurement", ReplyAction = "*")]
        Task<AddMeasurementResponse> AddMeasurementAsync(AddMeasurementRequest request);

        [OperationContract(Action = "http://www.grow-services.net/api/grow/soap/#getChartImage", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        GetChartImageResponse GetChartImage(GetChartImageRequest request);

        [OperationContract(Action = "http://www.grow-services.net/api/grow/soap/#getChartImage", ReplyAction = "*")]
        Task<GetChartImageResponse> GetChartImageAsync(GetChartImageRequest request);

        [OperationContract(Action = "http://www.grow-services.net/api/grow/soap/#getData", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        GetDataResponse GetData(GetDataRequest request);

        [OperationContract(Action = "http://www.grow-services.net/api/grow/soap/#getData", ReplyAction = "*")]
        Task<GetDataResponse> GetDataAsync(GetDataRequest request);

        [OperationContract(Action = "http://www.grow-services.net/api/grow/soap/#registerBirth", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        RegisterBirthResponse RegisterBirth(RegisterBirthRequest request);

        [OperationContract(Action = "http://www.grow-services.net/api/grow/soap/#registerBirth", ReplyAction = "*")]
        Task<RegisterBirthResponse> RegisterBirthAsync(RegisterBirthRequest request);

        [OperationContract(Action = "http://www.grow-services.net/api/grow/soap/#registerPregnancy", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        RegisterPregnancyResponse RegisterPregnancy(RegisterPregnancyRequest request);

        [OperationContract(Action = "http://www.grow-services.net/api/grow/soap/#registerPregnancy", ReplyAction = "*")]
        Task<RegisterPregnancyResponse> RegisterPregnancyAsync(RegisterPregnancyRequest request);

        [OperationContract(Action = "http://www.grow-services.net/api/grow/soap/#getPdf", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        GetPdfResponse GetPdf(GetPdfRequest request);

        [OperationContract(Action = "http://www.grow-services.net/api/grow/soap/#getPdf", ReplyAction = "*")]
        Task<GetPdfResponse> GetPdfAsync(GetPdfRequest request);

        [OperationContract(Action = "http://www.grow-services.net/api/grow/soap/#registerBaby", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        RegisterBabyResponse RegisterBaby(RegisterBabyRequest request);

        [OperationContract(Action = "http://www.grow-services.net/api/grow/soap/#registerBaby", ReplyAction = "*")]
        Task<RegisterBabyResponse> RegisterBabyAsync(RegisterBabyRequest request);

        [OperationContract(Action = "http://www.grow-services.net/api/grow/soap/#clearData", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        ClearDataResponse ClearData(ClearDataRequest request);

        [OperationContract(Action = "http://www.grow-services.net/api/grow/soap/#clearData", ReplyAction = "*")]
        Task<ClearDataResponse> ClearDataAsync(ClearDataRequest request);

        [OperationContract(Action = "http://www.grow-services.net/api/grow/soap/#getPregnancy", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        GetPregnancyResponse GetPregnancy(GetPregnancyRequest request);

        [OperationContract(Action = "http://www.grow-services.net/api/grow/soap/#getPregnancy", ReplyAction = "*")]
        Task<GetPregnancyResponse> GetPregnancyAsync(GetPregnancyRequest request);

        [OperationContract(Action = "http://www.grow-services.net/api/grow/soap/#removeMeasurement", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        RemoveMeasurementResponse RemoveMeasurement(RemoveMeasurementRequest request);

        [OperationContract(Action = "http://www.grow-services.net/api/grow/soap/#removeMeasurement", ReplyAction = "*")]
        Task<RemoveMeasurementResponse> RemoveMeasurementAsync(RemoveMeasurementRequest request);

        [OperationContract(Action = "http://www.grow-services.net/api/grow/soap/#updateMeasurement", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        UpdateMeasurementResponse UpdateMeasurement(UpdateMeasurementRequest request);

        [OperationContract(Action = "http://www.grow-services.net/api/grow/soap/#updateMeasurement", ReplyAction = "*")]
        Task<UpdateMeasurementResponse> UpdateMeasurementAsync(UpdateMeasurementRequest request);
    }
}