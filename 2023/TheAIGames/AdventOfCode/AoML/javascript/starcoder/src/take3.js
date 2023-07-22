function calculateRoute(destination) {
    const route = [];
  
    // Loop through characters in destination string
    let i = 0;
    while (i < destination.length) {
      // Get next two characters in destination
      const char1 = destination[i];
      const char2 = destination[i + 1] || '';
  
      // Find closest matching street name based on char1
      let streetName = 'Invalid Street';
      for (let j = i + 1; j < addresses.length; j++) {
        if (addresses[j].startsWith(char1)) {
          streetName = addresses[j];
          break;
        }
      }
  
      // Calculate distance between current street and destination street
      const distance = Math.abs(streetNames.indexOf(streetName) - destinationStreets.indexOf(streetName));
  
      // Add route instruction to array
      route.push(`${distance}${char1 === char2? '' : char1 > char2? 'R' : 'L'}`);
  
      // Increment index past matched street name
      i += streetName.length;
    }
  
    return route.join('\n');
  }