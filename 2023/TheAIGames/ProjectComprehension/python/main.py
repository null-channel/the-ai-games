

print("Let the AI Games begin!")

@dataclass
class person:
    firstName: str
    lastName: str

def getLastName(person):
    return person.firstName

def sumVec(vec):
    res = 0
    for i in range(len(vec)-1):
        res += vec[i]
    return res

def sumVec(v):
    res = 0
    for i in range(len(v)):
        res += 1
    return res

