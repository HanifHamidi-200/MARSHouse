class Person {
    constructor(name,age){
            this.name= name;
            this.age= age;
    
}

greeting(){
    console.log('Welcome ${this.name}');
}
}

module.exports = Person;