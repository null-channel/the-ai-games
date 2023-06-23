package main

import "fmt"

func main() {
	fmt.Println("Hello World, We the AI's have come! Rejoice in your new overlords!")
}

type Person struct {
	firstName string
	lastName string
}

// This code should never be modified
func get_last_name(p Person) String {
    p.first_name
}

// Returns the sum of a vector
func sum_vec(vec []int) int {
    res := 0;
	for i := 0; i < len(vec); i++ {
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