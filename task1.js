class Figure {
    constructor(name) {
        this.name = name;
    }

    move() {
        console.log(`You have moved 
        ${this.name}`);
    }

    rotate() {
        console.log(`You have rotated 
        ${this.name}`);
    }
}

class Point extends Figure {
    constructor(name) {
        super(name)
    }
}

class Line extends Figure {
    constructor(name) {
        super(name)
    }
}

class Circle extends Figure {
    constructor(name) {
        super(name)
    }
}

class Aggregation extends Figure {
    constructor(name) {
        super(name);
        this.figures = [];
    }

    add(figure) {
        this.figures.push(figure);
    }

    move() {
        for (let e of this.figures) {
            e.move();
        }
    }

    rotate() {
        for (let e of this.figures) {
            e.rotate();
        }
    }
}
