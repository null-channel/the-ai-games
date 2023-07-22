function findNextStreet(streets, letter, flipped, buildingNumber) {
    const startIndex = streets.findIndex((street) => {
      const words = street.split(" ");
      const currentWordIndex = flipped ? words.length - 1 : 0;
      const currentCharIndex = flipped ? buildingNumber.length - 1 : 0;
      const currentChar = words[currentWordIndex][currentCharIndex].toUpperCase();
      return currentChar === letter;
    });
  
    return streets.slice(startIndex + 1);
  }
  
  function calculateDirection(currentLetter, nextLetter, flipped, buildingNumber) {
    if (currentLetter.charCodeAt(0) > nextLetter.charCodeAt(0)) {
      return flipped ? "R" : "L";
    } else {
      return flipped ? "L" : "R";
    }
  }
  
  function generateDirections(streets) {
    const destination = streets.shift();
    const [buildingNumber, ...destinationWords] = destination.split(" ");
    let directions = [];
    let currentLetterIndex = 0;
    let flipped = false;
  
    for (let i = 0; i < destinationWords.join("").length; i++) {
      const currentLetter = destinationWords.join("").toUpperCase()[i];
      const nextLetter = destinationWords.join("").toUpperCase()[i + 1] || currentLetter;
  
      const remainingStreets = findNextStreet(streets, currentLetter, flipped, buildingNumber);
      const streetsToPass = streets.length - remainingStreets.length;
  
      if (currentLetter === " ") {
        flipped = !flipped;
      }
  
      directions.push(`${streetsToPass} ${calculateDirection(currentLetter, nextLetter, flipped, buildingNumber)}`);
      currentLetterIndex++;
      streets = remainingStreets;
    }
  
    directions.push(`D`);
    return directions.join("\n");
  }
  
  // Example usage
  const streetsList = [
    "2 Bob st",
    "Blammy st.",
    "Based road",
    "Basement bar st",
    "Oh the pain lane",
    "Krab are real st",
    "Never Bo lane",
    "Frightened Kitten St",
    "Please save us road",
    "Neverbefore seen cba road",
    "Fill",
    "fill",
    "Sonic outpost lane",
    "Fill",
    "fill",
    "Gin and Tonic",
  ];
  
  const directions = generateDirections(streetsList);
  console.log(directions);