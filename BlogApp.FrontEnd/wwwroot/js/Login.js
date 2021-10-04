var Login = (function ($container) {
    const URL_LOGIN = '/Account/Login',
        URL_REGISTER = '/Account/Register';

    var constMap, stateMap, jQueryMap, submit,
        onLogin, onRegister,

        init;

    stateMap = {
        data: {

        }
    };

    jQueryMap = {
        formSignin: $('.form-signin'),
        wrapperLogin: $('.wrapper-login'),
        wrapperRegister: $('.wrapper-register'),
        btnSignIn: $('.btn-signin'),
        btnSignUp: $('.btn-signup'),

    }

    onLogin = () => {
        var data = {
            Email: jQueryMap.wrapperLogin.find('input[name="Email"]').val(),
            Password: jQueryMap.wrapperLogin.find('input[name="Password"]').val()
        }

        if (data.Email.isNullOrEmpty()) {
            Notification.error("Email can't empty");
            return false;
        }

        if (data.Password.isNullOrEmpty()) {
            Notification.error("Password can't empty");
            return false;
        }

        $.ajax({
            method: 'POST',
            url: URL_LOGIN,
            data: data,
            success: function ({ success, Message }) {
                if (!success)
                    Notification.error(Message);
            },
            error: function ({ success, Message }) {
                debugger;
            }
        })
    };

    onRegister = () => {
        var data = {
            Email: jQueryMap.wrapperRegister.find('input[name="Email"]').val(),
            Password: jQueryMap.wrapperRegister.find('input[name="Password"]').val(),
            FirstName: jQueryMap.wrapperRegister.find('input[name="FirstName"]').val(),
            LastName: jQueryMap.wrapperRegister.find('input[name="LastName"]').val(),
        }

        if (data.Email.isNullOrEmpty()) {
            Notification.error("Email can't empty");
            return false;
        }

        if (data.Password.isNullOrEmpty()) {
            Notification.error("Password can't empty");
            return false;
        }

        if (data.FirstName.isNullOrEmpty()) {
            Notification.error("First Name can't empty");
            return false;
        }

        if (data.LastName.isNullOrEmpty()) {
            Notification.error("Last Name can't empty");
            return false;
        }

        $.ajax({
            method: 'POST',
            url: URL_REGISTER,
            data: data,
            success: function ({ success, Message }) {
                if (!success)
                    Notification.error(Message);
                else
                    Notification.success(Message);
            },
            error: function (err) {
                Notification.error(err);
            }
        })
    };

    init = function () {
        if (!mobileCheck()) {
            let heightLogin = $(window).height() - 100;
            jQueryMap.formSignin.height(heightLogin);
        }

        jQueryMap.wrapperLogin.find('.link-action').click(function () {
            jQueryMap.wrapperLogin.addClass('hide');
            jQueryMap.wrapperRegister.removeClass('hide');
        })

        jQueryMap.wrapperRegister.find('.link-action').click(function () {
            jQueryMap.wrapperRegister.addClass('hide');
            jQueryMap.wrapperLogin.removeClass('hide');
        });

        jQueryMap.btnSignIn.click(onLogin);
        jQueryMap.btnSignUp.click(onRegister);
    }


    return {
        init
    }
}($('html')))

Login.init();
