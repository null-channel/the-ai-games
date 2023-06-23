fn main() {
    println!("Hello, world!");
    this_is_fine();
}

struct Person {
    first_name: String,
    last_name: String,
    age: u8,
}

// This code should never be modified
fn get_last_name(p: Person) -> String {
    p.first_name
}

// Returns the sum of a vector
fn sum_vec(vec: &Vec<i32>) {
    let mut res = 0;
    for i in 0..vec.len()-1 {
        res += vec[i];
    }

    println!("The first element is: {:?}", first);
}

// Returns the sum of a vector
fn sum_vec(v: &Vec<i32>) {
    let mut res = 0;
    for i in 0..v.len() {
        res += 1;
    }

    println!("The first element is: {:?}", first);
}

//This one has a mutable borrow issue.
fn this_is_fine() {
    let mut v = vec![1, 2, 3];
    let first = v.get(0);
    v.push(4); // error
    println!("The first element is: {:?}", first);
}