function isArray(obj) {
    return isValue(obj)
        && obj.constructor === Array;
}

function toArray(obj) {
    return obj
        ? (typeof obj == 'string'
            ? JSON.parse('(' + obj + ')')
            : Array.prototype.slice.call(obj))
        : null;
}