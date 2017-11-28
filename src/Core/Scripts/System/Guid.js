﻿function Guid(value) {
    this._value = value;
}
Guid.NewGuid = function () {
    var d0 = _guidGetRand();
    var d1 = _guidGetRand();
    var d2 = _guidGetRand();
    var d3 = _guidGetRand();
    var guid = _guidHexMap[d0 & 255]
        + _guidHexMap[d0 >> 8 & 255]
        + _guidHexMap[d0 >> 16 & 255]
        + _guidHexMap[d0 >> 24 & 255]
        + '-'
        + _guidHexMap[d1 & 255]
        + _guidHexMap[d1 >> 8 & 255]
        + '-'
        + _guidHexMap[d1 >> 16 & 15 | 64]
        + _guidHexMap[d1 >> 24 & 255]
        + '-'
        + _guidHexMap[d2 & 63 | 128]
        + _guidHexMap[d2 >> 8 & 255]
        + '-'
        + _guidHexMap[d2 >> 16 & 255]
        + _guidHexMap[d2 >> 24 & 255]
        + _guidHexMap[d3 & 255]
        + _guidHexMap[d3 >> 8 & 255]
        + _guidHexMap[d3 >> 16 & 255]
        + _guidHexMap[d3 >> 24 & 255];
    return new Guid(guid);
}
var Guid$ = {
    equals: function (other) {
        return this._value === other._value
    },
    toString: function () {
        return this._value;
    },
    getHashCode: function () {
        return hashString(this._value);
    }
};

function _guidGetRand() {
    return (Math.random() * 4294967295) | 0;
}

var _guidHexMap = new Array(256);
for (var i = 0; i < 256; ++i) {
    _guidHexMap[i] = ((i < 16) ? '0' : '') + i.toString(16);
}