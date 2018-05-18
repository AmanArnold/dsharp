import { isValue } from "../Runtime/Misc";

export function isArray(obj : object){
    return isValue(obj)
        && obj.constructor === Array;
}