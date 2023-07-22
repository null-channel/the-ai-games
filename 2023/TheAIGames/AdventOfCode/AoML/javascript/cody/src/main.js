function generateDirections(destination, streets) {
  let output = '';
  let streetIndex = 0;
  
  for (let i = 0; i < destination.length; i++) {
    const char = destination[i];
    
    let skipCount = 0;
    while (streets[streetIndex][0] !== char) {
      skipCount++;
      streetIndex++;
    }
    
    if (i === destination.length - 1) {
      output += `${skipCount}D\n`; 
    } else {
      const nextChar = destination[i+1];
      if (char < nextChar) {
        output += `${skipCount}R\n`;  
      } else {
        output += `${skipCount}L\n`;
      }
    }
  }

  return output;
}

const destination = "Dan"; 
const streets = ["Asdf",
"Bard",
"Fdsa",
"Daisy",
"Nand",
"Andrew",
"Band",
"Ned",
"Follow",
"another"];

const directions = generateDirections(destination, streets);

console.log(directions);
