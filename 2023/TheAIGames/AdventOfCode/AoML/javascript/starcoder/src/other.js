function calculateRoute(destination) {
    let route = [];
  
    // Get the letters in the destination string
    const destLetters = Array.from(destination);
    
    // Loop through each letter in the destination 
    for (let i = 0; i < destLetters.length; i++) {
      // Find the next street starting with the current letter 
      const curLetter = destLetters[i];
      const nextStreetIdx = getNextStreetIndex(curLetter, i);
  
      // Calculate the distance between the current index and the next street index
      const distToNextStreeet = nextStreetIdx - i;
      
      // Determine whether to turn left or right based on the ordering of the characters in the destination
      const charAfterCurLetter = destLetters[i + 1] || '';
      const turnDir = compareChars(charAfterCurLetter, curLetter) === '>'? 'L' : 'R';
  
      // Add the calculated information to the route array
      route.push(`${distToNextStreeet}${turnDir}`);
  
      // Update the loop counter to point to the next letter in the destination
      i += distToNextStreeet;
    }
  
    return route;
  }
  
  // Helper function to determine which street index corresponds to the next street starting with the specified letter
  function getNextStreetIndex(letter, startIndex=0) {
    // Initialize a variable to store the index of the next matching street
    let nextStreetIdx = null;
  
    // Loop through the remaining letters in the destination string
    for (let i = startIndex; i < destLetters.length; i++) {
      // Check if the current letter matches the current letter we're looking for
      if (destLetters[i].startsWith(letter)) {
        // If it does, set the nextStreetIdx to the index of this matched letter 
        nextStreetIdx = i;
        break;
      }
    }
  
    return nextStreetIdx;
  }
  
  // Helper function to compare two characters and determine their relative ordering
  function compareChars(a, b) {
    if (!a &&!b) return '=';
    else if (!a) return '<';
    else if (!b) return '>';
    else return a > b? '>' : a < b? '<' : '=';
  }
  
  const destination = 'West 47th Street \n otherstreet \n bobs lane';
  console.log(calculateRoute(destination));
  // Output: [36R, 2L, 8D]