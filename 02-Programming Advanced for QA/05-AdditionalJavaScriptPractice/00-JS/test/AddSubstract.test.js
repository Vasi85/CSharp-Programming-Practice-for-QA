import { describe } from "mocha";
import { expect } from "chai";
import { createCalculator } from "../AddSubtract";

describe("createCalculator", () => {
    let calculator;

    beforeEach (() => {
        calculator = createCalculator();
    });

    it ("currectly add numbers", () => {
        calculator.add(2);
        expect(calculator.get()).to.equal(2);
    });

    it ("currently subtract numbers", () => {
        calculator.subtract(2);
        expect(calculator.get()).to.equal(-2);
    });

    it ("currectly parse strings", () => {
        calculator.add("2");
        expect(calculator.get()).to.equal(2);
    });

    it ("should't modify value", () => {
        expect(calculator.value).to.be.undefined;
    });
});
