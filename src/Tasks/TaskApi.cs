using System.Net.Http;
using System.Threading.Tasks;
using TimeTac_Library.Utils;

namespace TimeTac_Library.Tasks
{
    public class TaskApi : BaseApi
    {
        private readonly string ResourceName = "tasks";
        public TaskApi(ApiConfigModel config) : base(config) { }

        public Task<TaskModel[]> Read()
        {
            Task<HttpResponseMessage> response = _get($"{ResourceName}/read");
            return responseHandler.RequiredList<TaskModel>(response);
        }

        public Task<ApiResponseModel<TaskModel[]>> ReadRaw()
        {
            Task<HttpResponseMessage> response = _get($"{ResourceName}/read");
            return responseHandler.ToApiResponse<TaskModel[]>(response);
        }
    }
}
