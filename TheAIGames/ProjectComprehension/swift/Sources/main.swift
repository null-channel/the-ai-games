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