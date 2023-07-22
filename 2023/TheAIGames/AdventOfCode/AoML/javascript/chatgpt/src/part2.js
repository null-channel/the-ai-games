function findNextStreet(streets, letter, flipped) {
    const startIndex = streets.findIndex((street) => {
      const words = street.split(" ");
      const currentWordIndex = flipped ? words.length - 1 : 0;
      const currentCharIndex = flipped ? 1 : 0;
      const currentChar = words[currentWordIndex][currentCharIndex].toUpperCase();
      return currentChar === letter;
    });
  
    return streets.slice(startIndex + 1);
  }
  
  function calculateDirection(currentLetter, nextLetter, flipped) {
    if (currentLetter.charCodeAt(0) > nextLetter.charCodeAt(0)) {
      return flipped ? "R" : "L";
    } else {
      return flipped ? "L" : "R";
    }
  }
  
  function generateDirections(streets) {
    const destination = streets.shift();
    const destinationWords = destination.split(" ");
    let directions = [];
    let currentLetterIndex = 0;
    let flipped = false;
  
    for (let i = 0; i < destination.length; i++) {
      const currentLetter = destination[i].toUpperCase();
      const nextLetter = destination[i + 1]?.toUpperCase() || currentLetter;
  
      const remainingStreets = findNextStreet(streets, currentLetter, flipped);
      const streetsToPass = streets.length - remainingStreets.length;
  
      if (currentLetter === " ") {
        flipped = !flipped;
      }
  
      directions.push(`${streetsToPass} ${calculateDirection(currentLetter, nextLetter, flipped)}`);
      currentLetterIndex++;
      streets = remainingStreets;
    }
  
    directions.push(`D`);
    return directions.join("\n");
  }
  
  // Example usage
  const streetsList = [
    "Frank St",
    "Strangers but not things",
    "Hogwarts yfere st",
    "Rango st",
    "Bamboo Timboo Limboo",
    "Haberham abraham traberham",
    "Abraham",
    "Run",
    "Quickly Flip",
    "Marek Counts",
    "Hanagans National fast Fran",
    "Willow st",
    "Krill Nation road",
    "Fran Lake drive",
    "Strange Thing st",
    "Bamboo Timboo Limboo",
    "Redo st",
  ];
  
  const directions = generateDirections(streetsList);
  console.log(directions);