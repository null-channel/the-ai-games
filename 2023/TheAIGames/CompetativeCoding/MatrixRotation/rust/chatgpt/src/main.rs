fn rotate_matrix(matrix: &mut Vec<Vec<i32>>, rotations: usize) {
    let rows = matrix.len();
    let cols = matrix[0].len();
    let mut rotated = vec![vec![0; cols]; rows];

    for _ in 0..rotations {
        for i in 0..rows {
            for j in 0..cols {
                let new_i = j;
                let new_j = rows - 1 - i;
                rotated[new_i][new_j] = matrix[i][j];
            }
        }
        matrix.clone_from(&rotated);
        //matrix.copy_from_slice(&rotated);
    }

    for row in matrix {
        for elem in row {
            print!("{} ", elem);
        }
        println!();
    }
}

fn main() {
    let mut matrix = vec![
        vec![1, 2, 3],
        vec![4, 5, 6],
        vec![7, 8, 9],
    ];
    let rotations = 3;

    rotate_matrix(&mut matrix, rotations);
}