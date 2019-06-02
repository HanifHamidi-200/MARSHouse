const path = require('path');

console.log(path.basename(__filename));

console.log(path.dirname(__filename));

console.log(path.extname(__filename));



//Create path object
console.log(path.parse(__filename));
