var loadHlsStream = function (url, token, playerElement) {
    if (Hls.isSupported()) {
        var hls = new Hls();
        hls.loadSource(url + '&aestoken=' + token);
        hls.attachMedia(playerElement);
        hls.on(Hls.Events.MANIFEST_PARSED, function () {
            playerElement.play();
        });
    }
};