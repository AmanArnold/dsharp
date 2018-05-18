"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Misc_1 = require("../Runtime/Misc");
function isArray(obj) {
    return Misc_1.isValue(obj)
        && obj.constructor === Array;
}
exports.isArray = isArray;
//# sourceMappingURL=Array.js.map