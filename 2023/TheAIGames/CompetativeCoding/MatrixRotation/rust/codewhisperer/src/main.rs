fn main() {
    println!("Hello, world!");
    let matrix = vec![vec![1, 2, 3], vec![4, 5, 6], vec![7, 8, 9]];
    let k = 2;
    rotate_matrix(matrix, k);
}


//given a 2D matrix of dimension and a positive integer. You have to rotate the matrix a give number of times and print the resulting matrix. Rotation of the matrix should be in counter clockwise direction. 
//Examples:
//Input : mat[][] = {{1, 2, 3},
//                   {4, 5, 6},
//                   {7, 8, 9}}
//        k = 2
//Output : {{7, 4, 1},
//          {8, 5, 2},
//          {9, 6, 3}}
//
fn rotate_matrix(matrix: Vec<Vec<i32>>, k: i32) {
    let mut matrix = matrix;
    for _ in 0..k {
        matrix = rotate_matrix_once(matrix);
        println!("{:?}", matrix);
        println!("");
        println!("");
        println!("");
        println!("");
        println!("");
        println!("");
        println!("");
    }
    println!("{:?}", matrix);
    println!("");
    println!("");
}
fn rotate_matrix_once(matrix: Vec<Vec<i32>>) -> Vec<Vec<i32>> {
    let mut matrix = matrix;
    let n = matrix.len();
    for i in 0..n {
        for j in 0..n {
            if i < j {
                let temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
                println!("{:?}", matrix);
                println!("");
                println!("");
                println!("");
            }
            if i == j {
                let temp = matrix[i][j];
                matrix[i][j] = matrix[i][j];
                matrix[i][j] = temp;
                println!("{:?}", matrix);
                println!("");
            }
            if i > j {
                let temp = matrix[i][j];
                matrix[i][j] = matrix[i][j];
                matrix[i][j] = temp;
                println!("{:?}", matrix);
                println!("");
            }
            println!("");
        }
        println!("");
    }
    println!("");
    matrix
}