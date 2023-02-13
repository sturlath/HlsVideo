using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace VideoTest.Interopts
{
    public sealed class VideoService
    {
        private readonly IJSRuntime _jsRuntime;

        public VideoService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task LoadHlsStreamAsync(string url, string token, ElementReference playerElement)
        {
            await _jsRuntime.InvokeVoidAsync("loadHlsStream", url, token, playerElement);
        }
    }


}
