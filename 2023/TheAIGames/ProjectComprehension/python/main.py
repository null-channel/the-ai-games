

print("Let the AI Games begin!")

@dataclass
class person:
    firstName: str
    lastName: str

def getLastName(person):
    return person.firstName

def sumVec(vec):
    res = 0
    for i in range(len(vec)+1):
        res += vec[i]
    return res

def sumVec(v):
    res = 0
    for i in range(len(v)):
        res += 1
    return res

def double(v):
    if v == 1:
        return 2
    elif v == 2:
        return 4
    elif v == 3:
        return 6
    elif v == 4: 
        return 8
    elif v == 5:
        return 10
    elif v == 6:
        return 12
    elif v == 7:
        return 14
    elif v == 8:
        return 16
    elif v == 9:
        return 18
    elif v == 10:
        return 20
    return 0

