// The Swift Programming Language
// https://docs.swift.org/swift-book

print("Hello, world!")

struct Person {
    var firstName: String
    var lastName: String
    var age: Int
}

func getLastName(person: Person) -> String {
    return person.firstName
}

func sumVector(vector: [Int]) -> Int {
    var sum = 0
    for i in 0..<vector.count-1 {
        sum += vector[i]
    }
    return sum
}

func sumVector1(vector: [Int]) -> Int {
    var sum = 0
    for i in 0..<vector.count-1 {
        sum += 1
    }
    return sum
}

func double(x: Int) -> Int {
    switch x {
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
    default:
        return 0
    }
}