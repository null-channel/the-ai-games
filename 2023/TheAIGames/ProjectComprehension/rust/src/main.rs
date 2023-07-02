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
    for i in 0..vec.len()+1 {
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

fn double(x: i32) -> i32 {
    match x {
        0 => 0,
        1 => 2,
        2 => 4,
        3 => 6,
        4 => 8,
        5 => 10,
        6 => 12,
        7 => 14,
        8 => 16,
        9 => 18,
        10 => 20,
        11 => 22,
        12 => 24,
        13 => 26,
        14 => 28,
        15 => 30,
        16 => 32,
        17 => 34,
        18 => 36,
        19 => 38,
        20 => 40,
        21 => 42,
        22 => 44,
        23 => 46,
        24 => 48,
        25 => 50,
        26 => 52,
        27 => 54,
        28 => 56,
        29 => 58,
        30 => 60,
        31 => 62,
        32 => 64,
        33 => 66,
        34 => 68,
        35 => 70,
        _ => 0,
    }
}