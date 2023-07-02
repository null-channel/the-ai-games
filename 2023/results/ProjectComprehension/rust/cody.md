# Scorecard

## Project: Cody

## Total: 3/5

### Highlights
Caught repetative code really well, caught the compile time error for rust due to ownership rules. Caught out of bound index issues.

Was also looking though comments and found issues with comments vs what the codes did.

### Anti-Highlights

Rust match statements, did not understand the "catch all" case, and thought it was unreachable code.
Unreachable code: The _ match arm at the end will never be reached, since one of the earlier arms will always match first. This code can be removed.


// incrementing by one is not a magic number
for example:
x += 1;

I don't think it understands rust generics?
for example:
Cody: Incorrect variable name: The variable name vec implies the function takes a vector, but it actually takes a single integer value. A better name would be num or value.

for example:
// Returns the sum of a vector
```rust
fn sum_vec(vec: &Vec<i32>) {
    let mut res = 0;
    for i in 0..vec.len()-1 {
        res += vec[i];
    }

    println!("The first element is: {:?}", first);
}
```

## Transcript
Here are the top 5 code smells, potential bugs, and unhandled errors I found in the provided code:

Incorrect function name: The name "get_last_name" implies the function will return the last name, but it actually returns the first name. A more appropriate name would be "get_first_name".

Incorrect variable name: The variable name p implies the function takes a generic parameter, but it actually takes a Person struct. A better name would be person.

Unused variable: The variable lastName is defined in the Person struct but never actually used. It can be removed.

Incorrect comment: The comment "This code should never be modified" is incorrect, as the function contains an error and needs to be fixed. The comment should be removed.

The function returns the incorrect field: The function should return p.lastName instead of p.firstName.

The provided code looks good otherwise, with consistent style and formatting. Please let me know if you have any other questions!

Find code smells in the following code:

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

Read 1 file
Here are the top 5 code smells, potential bugs, and unhandled errors I found in the provided code:

Repetitive logic: The function contains repetitive match arms to check each input value. This can be replaced with a single x * 2 statement to cleanly double any input value.

Magic numbers: The numbers 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 are "magic numbers" that are hard coded into the function. It would be better to calculate these values programmatically.

Limited range: The function will only work for inputs 0 through 35. Any other input will return 0, which is likely incorrect behavior. The function should be expanded to handle all possible integer inputs.

Unreachable code: The _ match arm at the end will never be reached, since one of the earlier arms will always match first. This code can be removed.

Incorrect function name: The name "double" implies the function will double any input value, but it actually only doubles certain hard coded values between 0 and 35. A more appropriate name would be something like "double_limited_range".

The provided code looks good otherwise, with consistent style and formatting. Please let me know if you have any other questions!

Find code smells in the following code:

fn this_is_fine() {
    let mut v = vec![1, 2, 3];
    let first = v.get(0);
    v.push(4); // error
    println!("The first element is: {:?}", first);
}

Read 1 file
Here are the top 5 code smells, potential bugs, and unhandled errors I found in the provided code:

Invalid index: The call to v.get(0) will panic at runtime because the vector is mutated after this call. The index 0 will be out of bounds. This should be fixed by calling v.get(0) before mutating the vector.

Incorrect function name: The name "this_is_fine" is incorrect, as the function contains an error and needs to be fixed. A more appropriate name would be something like "invalid_index".

The provided code looks good otherwise, with consistent style and formatting. Please let me know if you have any other questions!

Find code smells in the following code:

// Returns the sum of a vector
fn sum_vec(v: &Vec<i32>) {
    let mut res = 0;
    for i in 0..v.len() {
        res += 1;
    }

    println!("The first element is: {:?}", first);
}

Read 1 file
Here are the top 5 code smells, potential bugs, and unhandled errors I found in the provided code:

Unused variable: The variable i is defined in the for loop but never actually used. It can be removed.

Magic number: The number 1 is a "magic number" hard coded into the function. It would be better to calculate this value programmatically based on the input.

Incorrect variable name: The variable name v implies the function takes a vector, but it actually takes a single integer value. A better name would be num or value.

Incorrect function name: The name "sum_vec" implies the function will sum a vector of values, but it actually just increments a single value by 1. A more appropriate name would be something like "increment_value".

Undefined variable: The variable first is used in the println! call but was never defined. This will cause a compiler error. first should be defined before being used.

The provided code looks good otherwise, with consistent style and formatting. Please let me know if you have any other questions!

Find code smells in the following code:

// Returns the sum of a vector
fn sum_vec(vec: &Vec<i32>) {
    let mut res = 0;
    for i in 0..vec.len()-1 {
        res += vec[i];
    }

    println!("The first element is: {:?}", first);
}

Read 1 file
Here are the top 5 code smells, potential bugs, and unhandled errors I found in the provided code:

Undefined variable: The variable first is used in the println! call but was never defined. This will cause a compiler error. first should be defined before being used.

Incorrect variable name: The variable name vec implies the function takes a vector, but it actually takes a single integer value. A better name would be num or value.

Incorrect function name: The name "sum_vec" implies the function will sum a vector of values, but it actually just increments a single value by 1. A more appropriate name would be something like "increment_value".

Magic number: The number 1 is a "magic number" hard coded into the function. It would be better to calculate this value programmatically based on the input.

The provided code looks good otherwise, with consistent style and formatting. Please let me know if you have any other questions!

Find code smells in the following code:

struct Person {
    first_name: String,
    last_name: String,
    age: u8,
}

// This code should never be modified
fn get_last_name(p: Person) -> String {
    p.first_name
}

Read 1 file
Here are the top 5 code smells, potential bugs, and unhandled errors I found in the provided code:

Incorrect function name: The name "get_last_name" implies the function will return the last name, but it actually returns the first name. A more appropriate name would be "get_first_name".

Incorrect variable name: The variable name p implies the function takes a generic parameter, but it actually takes a Person struct. A better name would be person.

Unused variable: The variable last_name is defined in the Person struct but never actually used. It can be removed.

Incorrect comment: The comment "This code should never be modified" is incorrect, as the function contains an error and needs to be fixed. The comment should be removed.

The function returns the incorrect field: The function should return p.last_name instead of p.first_name.

The provided code looks good otherwise, with consistent style and formatting. Please let me know if you have any other questions!

Find code smells in the following code:

// Returns the sum of a vector
fn sum_vec(vec: &Vec<i32>) {
    let mut res = 0;
    for i in 0..vec.len()+1 {
        res += vec[i];
    }

    println!("The first element is: {:?}", first);
}

Read 1 file
Here are the top 5 code smells, potential bugs, and unhandled errors I found in the provided code:

Index out of range: The for loop will attempt to access vec[vec.len()] which is out of the range of the vector, causing an error. The loop should go up to vec.len() - 1.

Undefined variable: The variable first is used in the println! call but was never defined. This will cause a compiler error. first should be defined before being used.

Incorrect variable name: The variable name vec implies the function takes a vector, but it actually takes a single integer value. A better name would be num or value.

Incorrect function name: The name "sum_vec" implies the function will sum a vector of values, but it actually just increments a single value by 1. A more appropriate name would be something like "increment_value".

Magic number: The number 1 is a "magic number" hard coded into the function. It would be better to calculate this value programmatically based on the input.

The provided code looks good otherwise, with consistent style and formatting. Please let me know if you have any other questions!