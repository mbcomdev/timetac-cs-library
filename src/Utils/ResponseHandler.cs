using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace TimeTac_Library.Utils
{
    public class ResponseHandler
    {
        public async Task<ApiResponseModel<T>> ToApiResponse<T>(Task<HttpResponseMessage> task)
        {
            HttpResponseMessage response = await task;
            string responseContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseContent);
            ApiResponseModel<T> apiResponse = JsonSerializer.Deserialize<ApiResponseModel<T>>(responseContent, new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                PropertyNameCaseInsensitive = true,
            });
            if (apiResponse.Success)
            {
                return apiResponse;
            }
            throw new ApiException(apiResponse.ErrorMessage, apiResponse.ErrorExtended, apiResponse.ErrorInternal);
        }

        public async Task<T> RequiredObject<T>(Task<HttpResponseMessage> task)
        {
            ApiResponseModel<T> response = await ToApiResponse<T>(task);
            if (response.NumResults > 0)
            {
                return response.Results;
            }
            else
            {
                throw new ApiException("There are no results");
            }
        }
        public async Task<T> Required<T>(Task<HttpResponseMessage> task)
        {
            ApiResponseModel<T[]> response = await ToApiResponse<T[]>(task);
            if (response.NumResults > 0)
            {
                return response.Results[0];
            }
            else
            {
                throw new ApiException("There are no results");
            }
        }
        public async Task<T[]> RequiredList<T>(Task<HttpResponseMessage> task)
        {
            ApiResponseModel<T[]> response = await ToApiResponse<T[]>(task);
            if (response.NumResults > 0)
            {
                return response.Results;
            }
            else
            {
                throw new ApiException("There are no results");
            }
        }
        public async Task<T> Optional<T>(Task<HttpResponseMessage> task)
        {
            ApiResponseModel<T[]> response = await ToApiResponse<T[]>(task);
            return response.NumResults > 0 && response.Results[0] != null ? response.Results[0] : default;
        }

        public async Task<T[]> OptionalList<T>(Task<HttpResponseMessage> task)
        {
            ApiResponseModel<T[]> response = await ToApiResponse<T[]>(task);
            return response.NumResults > 0 && response.Results != null ? response.Results : Array.Empty<T>();
        }
    }
}
