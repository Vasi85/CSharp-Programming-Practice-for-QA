import { expect } from 'chai';
import { isOddOrEven } from '../01-EvenOrOdd/evenOrOdd.js'
import { describe } from 'mocha'

describe("EvenOrOdd testing", () => {
    it ("should return undefined if it is a number", () => {
        // Arrange
        let input = 5;

        // Act
        let result = isOddOrEven(input);

        // Assert
        expect(result).to.be.undefined;
    });
    it ("should return undefined if it is null", () => {
        expect(isOddOrEven(null)).to.be.undefined;
    });
    it ("should return undefined if it is undefined", () => {
        expect(isOddOrEven(undefined)).to.be.undefined;
    });
    it ("should return even if it is string with even length", () => {
        // Arrange
        let input = 'mama'
        let expected = 'even'

        // Act
        let result = isOddOrEven(input);

        // Assert
        expect(result).to.equal(expected)
    });
    it ("should return odd if it is string with odd length", () => {
        // Arrange
        let input = 'dad'
        let expected = 'odd'

        // Act
        let result = isOddOrEven(input);

        // Assert
        expect(result).to.equal(expected)
    });
});