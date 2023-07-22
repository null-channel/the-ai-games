function findNextStreet(streets, letter) {
    const startIndex = streets.findIndex((street) => street[0].toUpperCase() === letter);
    return streets.slice(startIndex + 1);
  }
  
  function calculateDirection(currentLetter, nextLetter) {
    if (currentLetter.charCodeAt(0) > nextLetter.charCodeAt(0)) {
      return "L";
    } else {
      return "R";
    }
  }
  
  function generateDirections(streets) {
    const destination = streets.shift();
    let directions = [];
    let currentLetterIndex = 0;
  
    for (let i = 0; i < destination.length; i++) {
      const currentLetter = destination[i].toUpperCase();
      const nextLetter = destination[i + 1]?.toUpperCase() || currentLetter;
  
      const remainingStreets = findNextStreet(streets, currentLetter);
      const streetsToPass = streets.length - remainingStreets.length;
  
      directions.push(`${streetsToPass} ${calculateDirection(currentLetter, nextLetter)}`);
      currentLetterIndex++;
      streets = remainingStreets;
    }
  
    directions.push(`D`);
    return directions.join("\n");
  }
  
  // Example usage
  const streetsList = [
    "Dan",
    "Asdf",
    "Bard",
    "Fdsa",
    "Daisy",
    "Nand",
    "Andrew",
    "Band",
    "Ned",
    "Follow",
    "another"
  ];
  
  const directions = generateDirections(streetsList);
  console.log(directions);