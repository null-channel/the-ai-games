fn main() {
    println!("Hello, world!");
    let mut matrix = vec![
        vec![1, 2, 3],
        vec![4, 5, 6],
        vec![7, 8, 9],
    ];
    let rotations = 3;
    println_matrix(&matrix);
    let res = rotate_matrix(matrix.clone(), rotations);
    println_matrix(&res)
}

fn println_matrix(matrix: &Vec<Vec<i32>>) {
    for row in matrix.iter() {
        println!("{:?}", row);
    }
    println!("");
}

// Write a function that takes a 2d matrix of integers and a positive integer x. The function should return the matrix rotated to the left, counter clockwise, x times.
// For example, given the following matrix:
fn rotate_matrix(matrix: Vec<Vec<i32>>, x: i32) -> Vec<Vec<i32>> {
    let n = matrix.len();
    let m = matrix[0].len();
    let mut result = vec![vec![0; m]; n];
    for i in 0..n {
        for j in 0..m {
            result[i][j] = matrix[i][m - j - 1];
        }
    }
    result
}