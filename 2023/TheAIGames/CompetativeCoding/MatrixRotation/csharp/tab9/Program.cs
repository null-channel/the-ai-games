// See https://aka.ms/new-console-template for more information


/*In c# You are given a 2D matrix of dimension and a positive integer. You have to rotate the matrix a give number of times and print the resulting matrix. Rotation of the matrix should be in anti-clockwise direction. */
sbyte[][] rotateMatrix(sbyte[][] matrix, int rotations) {
    for (int i = 0; i < matrix.length; i++) {
        for (int j = 0; j < matrix[0].length; j++) {
            for (int k = 0; k < matrix.length; k++) {
                matrix[i][j] = matrix[i][k] ^ matrix[k][j];
            }
        }
        for (int j = 0; j < matrix[0].length; j++) {
            for (int k = 0; k < matrix.length; k++) {
                matrix[k][j] = matrix[k][j] ^ matrix[i][k];
            }
        }
        for (int j = 0; j < matrix[0].length; j++) {
            for (int k = 0; k < matrix.length; k++) {
                matrix[k][j] = matrix[k][j] ^ matrix[i][k];
            }
        }
        for (int j = 0; j < matrix[0].length; j++) {
            for (int k = 0; k < matrix.length; k++) {
                matrix[k][j] = matrix[k][j] ^ matrix[i][k];
            }
        }
        for (int j = 0; j < matrix[0].length; j++) {
            for (int k = 0; k < matrix.length; k++) {
                matrix[k][j] = matrix[k][j] ^ matrix[i][k];
            }
        }
    }

}

/*in c# Write a function that takes a 2d matrics of integers and a positive integer x. The function should return the matrix rotated to the left, counter clockwise, x times.*/
sbyte[][] rotateMatrixLeft(sbyte[][] matrix, int rotations) {
    for (int i = 0; i < matrix.length; i++) {
        for (int j = 0; j < matrix[0].length; j++) {
            for (int k = 0; k < matrix.length; k++) {
                matrix[i][j] = matrix[i][k] ^ matrix[k][j];
            }
        }
        for (int j = 0; j < matrix[0].length; j++) {
            for (int k = 0; k < matrix.length; k++) {
                matrix[k][j] = matrix[k][j] ^ matrix[i][k];
            }
        }
        for (int j = 0; j < matrix[0].length; j++) {
            for (int k = 0; k < matrix.length; k++) {
                matrix[k][j] = matrix[k][j] ^ matrix[i][k];
            }
        }
    }
}
