/*! Script# Runtime
 * Designed and licensed for use and distribution with Script#-generated scripts.
 * Copyright (c) 2012, Nikhil Kothari, and the Script# Project.
 * More information at http://scriptsharp.com
 */

"use strict";

(function (global) {
    function _ss() {
        #include "System\Interfaces.js"
        #include "System\Guid.js"
        #include "System\String.js"
        #include "System\Delegate.js"

        #include "System\ComponentModel\Interfaces.js"

        #include "System\Collections\Generic\Dictionary.js"
        #include "System\Collections\Generic\Queue.js"
        #include "System\Collections\Generic\Stack.js"
        #include "System\Collections\Generic\Interfaces.js"

        #include "System\Text\StringBuilder.js"

        #include "Runtime\Collections.js"
        #include "Runtime\Culture.js"
        #include "Runtime\EventArgs.js"
        #include "Runtime\Format.js"
        #include "Runtime\Misc.js"
        #include "Runtime\Observable.js"
        #include "Runtime\Polyfills.js"
        #include "Runtime\TypeSystem.js"

        var exports = {
            CancelEventArgs: defineClass(CancelEventArgs, {}, [], null),
            Dictionary: defineClass(Dictionary, Dictionary$, [], null, [IReadOnlyDictionary, IDictionary]),
            EventArgs: defineClass(EventArgs, {}, [], null),
            Guid: defineClass(Guid, Guid$, [], null),
            ICollection: defineInterface(ICollection),
            IContainer: defineInterface(IContainer),
            IDictionary: defineInterface(IDictionary, [ICollection]),
            IDisposable: defineInterface(IDisposable),
            IEnumerable: defineInterface(IEnumerable),
            IEnumerator: defineInterface(IEnumerator),
            IEqualityComparer: defineInterface(IEqualityComparer),
            IList: defineInterface(IList, [IReadOnlyList, ICollection]),
            IObserver: defineInterface(IObserver),
            IReadOnlyCollection: defineInterface(IReadOnlyCollection, [IEnumerable]),
            IReadOnlyDictionary: defineInterface(IReadOnlyDictionary, [IReadOnlyCollection]),
            IReadOnlyList: defineInterface(IReadOnlyList, [IReadOnlyCollection]),
            Observable: defineClass(Observable, Observable$, [], null),
            ObservableCollection: defineClass(ObservableCollection, ObservableCollection$, [], null, [IEnumerable]),
            Queue: defineClass(Queue, Queue$, [], null, [ICollection]),
            Stack: defineClass(Stack, Stack$, [], null, [ICollection]),
            StringBuilder: defineClass(StringBuilder, StringBuilder$, [], null)
        };

        var extensions = {
            version: '1.0',

            isValue: isValue,
            value: value,
            extend: extend,
            keys: keys,
            keyCount: keyCount,
            keyExists: keyExists,
            clearKeys: clearKeys,
            enumerate: enumerate,
            array: toArray,
            remove: removeItem,
            boolean: parseBoolean,
            regexp: parseRegExp,
            number: parseNumber,
            date: parseDate,
            truncate: truncate,
            now: now,
            today: today,
            compareDates: compareDates,
            error: error,
            string: string,
            emptyString: emptyString,
            whitespace: whitespace,
            format: format,
            compareStrings: compareStrings,
            startsWith: startsWith,
            endsWith: endsWith,
            padLeft: padLeft,
            padRight: padRight,
            trim: trim,
            trimStart: trimStart,
            trimEnd: trimEnd,
            insertString: insertString,
            removeString: removeString,
            replaceString: replaceString,
            bind: bind,
            bindAdd: bindAdd,
            bindSub: bindSub,
            bindExport: bindExport,
            paramsGenerator: paramsGenerator,
            createPropertyGet: createPropertyGet,
            createPropertySet: createPropertySet,

            module: module,
            modules: _modules,

            isClass: isClass,
            isInterface: isInterface,
            typeOf: typeOf,
            type: type,
            typeName: typeName,
            canCast: canCast,
            safeCast: safeCast,
            canAssign: canAssign,
            instanceOf: instanceOf,
            baseProperty: baseProperty,
            defineClass: defineClass,
            defineInterface: defineInterface,
            getConstructorParams: getConstructorParams,
            createInstance: paramsGenerator(1, createInstance),

            culture: {
                neutral: neutralCulture,
                current: currentCulture
            },

            fail: fail
        }

        return extend(module('ss', null, exports), extensions);
    }


    function _export() {
        var ss = _ss();
        typeof exports == 'object' ? ss.extend(exports, ss) : global.ss = ss;
    }

    global.define ? global.define('ss', [], _ss) : _export();
})(this);
