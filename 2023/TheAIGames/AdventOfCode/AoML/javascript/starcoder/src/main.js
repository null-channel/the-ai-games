const input = `Broadway
West Broadway
Worth Street`

// split by lines
let lines = input.split('\n');

// extract destination (first element)
let dest = lines[0];
console.log(`Destination: ${dest}`);

// remove leading/trailing whitespace
lines = lines.map(line => line.trim());

// loop through letters in destination string
for (let i = 0; i < dest.length - 1; i++) {
  // grab current char & next char
  let currChar = dest[i],
    nextChar = dest[i + 1];

  // calculate index of next matching street name 
  let idx = lines.findIndex((street) => 
    street[0] === currChar && street[1].toLowerCase() > nextChar);
  
  console.log(`${currChar}: Skip ${lines[idx][0]}${lines[idx][1]? ' : ''}${lines[idx][1] || ''}`);
}


