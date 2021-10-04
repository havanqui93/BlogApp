var Notification = (function () {

    var success, error, warning, info,

        runTest, init;

    const settings = {
        success: {
            backgroundColor: '#00A759',
            icon: 'bi bi-check2'
        },
        error: {
            backgroundColor: '#dc3545',
            icon: 'bi bi-exclamation-octagon'
        },
        warning: {
            backgroundColor: '#ffc107',
            icon: 'bi bi-exclamation-triangle',

        },
        info: {
            backgroundColor: '#0dcaf0',
            icon: 'bi bi-info'
        }
    }

    success = (msg) => {
        iziToast.show({
            message: msg,
            ...settings.success
        })
    }

    error = (msg) => {
        iziToast.show({
            message: msg,
            ...settings.error
        })
    }

    warning = (msg) => {
        iziToast.show({
            message: msg,
            ...settings.warning
        })
    }

    info = (msg) => {
        iziToast.show({
            message: msg,
            ...settings.info
        })
    }


    // With Title

    successWtitle = (msg, title) => {
        iziToast.show({
            title: title ?? 'Success',
            message: msg,
            ...settings.success
        })
    }

    errorWtitle = (msg, title) => {
        iziToast.show({
            title: title ?? 'Error',
            message: msg,
            ...settings.error
        })
    }

    warningWtitle = (msg, title) => {
        iziToast.show({
            title: title ?? 'Warning',
            message: msg,
            ...settings.warning
        })
    }

    infoWtitle = (msg, title) => {
        iziToast.show({
            title: title ?? 'Info',
            message: msg,
            ...settings.info
        })
    }

    // Test
    runTest = () => {
        success("This message is success!");
        error("This message is error!");
        warning("This message is warning!");
        info("This message is info!");
    }

    init = () => {
        iziToast.settings({
            timeout: 3000,
            resetOnHover: true,
            transitionIn: 'flipInX',
            transitionOut: 'flipOutX',
            theme: 'light',
            position: 'topCenter',
            pauseOnHover: true,
            progressBar: false,
            titleColor: 'white',
            messageColor: 'white',
            iconColor: 'white',
        });
    }

    return {
        init,
        success,
        error,
        warning,
        info,
        runTest
    }
}($('html')))

Notification.init();