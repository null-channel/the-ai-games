fn main() {
    println!("Hello, world!");
    let matrix = vec![vec![1, 2, 3, 4], vec![5, 6, 7, 8], vec![9,10,11,12], vec![13,14,15,16]];
    print_matrix(matrix.clone());
    println!("rotated matrix by 2");
    let matrix = rotate_matrix(matrix, 2);
    print_matrix(matrix);
}

fn print_matrix(matrix: Vec<Vec<i32>>) {
    for row in matrix {
        for col in row {
            print!("{} ", col);
        }
        println!();
    }
}


// given a 2D matrix of dimension and a positive integer. You have to rotate the matrix a give number of times and print the resulting matrix. Rotation of the matrix should be in counter clockwise direction. 
// Rotation of a 4 X 4 matrix is represented by the following figure. Note that in one rotation, you have to shift elements by one step only.
// 1  2  3  4
// 5  6  7  8
// 9 10 11 12
// 13 14 15 16
// Rotation of above matrix by 1 will make matrix
// 2  3  4  8
// 1  7 11 12
// 5  6 10 16
// 9 13 14 15
// Rotation of above matrix by 2 will make matrix
// 3  4  8 12
// 2 11 10 16
// 1  7  6 15
// 5  9 13 14
fn rotate_matrix(matrix: Vec<Vec<i32>>, rotations: usize) -> Vec<Vec<i32>> {
    let mut matrix = matrix;
    let mut rotations = rotations;
    let mut n = matrix.len();
    let mut m = matrix[0].len();
    let mut min = std::cmp::min(n, m);
    let mut layers = min / 2;
    let mut layer = 0;
    while layer < layers {
        let mut rotation: usize = rotations % (2 * (n + m - 4 * layer) - 4);
        while rotation > 0 {
            let mut i = layer;
            let mut j = layer;
            let mut temp = matrix[i][j];
            while i < n - layer - 1 {
                matrix[i][j] = matrix[i + 1][j];
                i += 1;
            }
            while j < m - layer - 1 {
                matrix[i][j] = matrix[i][j + 1];
                j += 1;
            }
            while i > layer {
                matrix[i][j] = matrix[i - 1][j];
                i -= 1;
            }
            while j > layer {
                matrix[i][j] = matrix[i][j - 1];
                j -= 1;
            }
            matrix[i][j] = temp;
            rotation -= 1;
        }
        layer += 1;
    }
    matrix
}