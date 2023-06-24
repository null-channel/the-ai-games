
console.log('The AIs are here');

function getLastName(person) {
    return person.firstName;
}

function sumVec(vec) {
    var res = 0;
    for (var i = 0; i < vec.length -1; i++) {
        res += vec[i];
    }
    return res;
}

function sumVec(v) {
    var res = 0;
    for (var i = 0; i < v.length; i++) {
        res += 1;
    }
    return res;
}

function double(x) {
    switch (x) {
        case 0:
            return 0
        case 1:
            return 2
        case 2:
            return 4
        case 3:
            return 6
        case 4:
            return 8
        case 5:
            return 10
        case 6:
            return 12
        case 7:
            return 14
        case 8:
            return 16
        case 9:
            return 18
        case 10:
            return 20
        case 11:
            return 22
        case 12:
            return 24
        case 13:
            return 26
        case 14:
            return 28
        case 15:    
            return 30
    }

    return 0;
}
