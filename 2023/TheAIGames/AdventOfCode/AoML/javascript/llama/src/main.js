//https://labs.perplexity.ai/

function generateDirections(destination) {
  // Split the destination into individual characters
  const destChars = destination.split(''); // Initialize variables to keep track of the current street and turning direction
  let currentStreet = '';
  let turningDirection = 'R'; // Right by default // Iterate through each character of the destination
  for (let i = 0; i < destChars.length; i++) { // Check if the current character is the last one in the destination
  if (i === destChars.length - 1) { // If it is, set the current street to the last character and break out of the loop
  currentStreet = destChars[i];
  break;
  }

  // Otherwise, check if the current character is the same as the previous character
if (destChars[i] === destChars[i - 1]) { // If it is, continue to the next character
  continue;
  } // Otherwise, determine the turning direction based on the current character and the previous character
  switch (destChars[i]) {
  case 'L':
  turningDirection = 'L';
  break;
  case 'R':
  turningDirection = 'R';
  break;
  default:
  turningDirection = 'D';
  break;
  } // Update the current

  // Update the current street and turning direction
currentStreet += destChars[i];
turningDirection = determineturningDirection(currentStreet, turningDirection); // Print the directions
console.log(Turn right onto ${currentStreet});
console.log(Continue straight until reaching ${destiny})); // Return the final street name
return currentStreet;
} // Helper function to determine the turning direction
function determineturningDirection(currentStreet, previous Street) { // Check if the current street starts with the same letter as the previous street
if (currentStreet.charAt(0) === previousStreet.charAt(0)) { // If it does, return the opposite direction
return previousStreet.charAt(0) === 'L' ? 'R' : 'L';
} // Otherwise, return the default direction ('D')
return 'D';
}