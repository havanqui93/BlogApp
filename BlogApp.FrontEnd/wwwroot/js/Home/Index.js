var HomeComponent = (function ($container) {
    const URL_LOAD = '',
        URL_LOG_OUT = 'Account/Logout';

    var constMap, stateMap, jQueryMap, submit, eventFunction,
        onLogOut,

        init;

    stateMap = {
        data: {

        }
    };

    jQueryMap = {
        btnLogout: $container.find('.log-out'),

    }

    onLogOut = () => {
        $.ajaxPost(URL_LOG_OUT, null, function (data) {

        }, function (error) {

        });
    };

    eventFunction = () => {
        jQueryMap.btnLogout.click(onLogOut);


    };

    init = () => {
        eventFunction();

    }

    return {
        init
    }
}($('html')))

HomeComponent.init();