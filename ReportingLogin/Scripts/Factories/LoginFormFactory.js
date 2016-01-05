﻿var LoginFormFactory = function ($http) {
        var fac = {};
        fac.GetUser = function (d) {
            return $http({
                url: '/Home/UserLogin',
                method: 'POST',
                data: JSON.stringify(d),
                headers: { 'content-type': 'application/json' }
            });
        };
        return fac;
    }