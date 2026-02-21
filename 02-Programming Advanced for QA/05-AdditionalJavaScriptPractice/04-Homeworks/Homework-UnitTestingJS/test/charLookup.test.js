import { lookupChar } from '../02-CharLookup/charLookup.js'
import { describe } from 'mocha'
import { expect } from 'chai'

describe ('Charlookup testing', () => {
    it ('should return undefined if the input is not correct', () => {
        expect(lookupChar(5, 2)).to.be.undefined;
        expect(lookupChar(null, 2)).to.be.undefined;
        expect(lookupChar('mama', '2')).to.be.undefined;
        expect(lookupChar('mama', null)).to.be.undefined;
        expect(lookupChar('mama', '/')).to.be.undefined;
        expect(lookupChar('mama', 1.2)).to.be.undefined;
        expect(lookupChar('mama', 'm')).to.be.undefined;
    });
    it ('should return "Incorrect index" if index is incorrect', () => {
        // Arrange
        let expected = "Incorrect index";

        // Act & Assert
        expect(lookupChar('mama', -1)).to.equal(expected);
        expect(lookupChar('mama', 4)).to.equal(expected);
        expect(lookupChar('mama', 7)).to.equal(expected);
    });
    it ('should return index if input is valid', () => {
        expect(lookupChar('mama', 3)).to.equal('a');
        expect(lookupChar('Bistra', 0)).to.equal('B');
        expect(lookupChar('Barbalena', 5)).to.equal('l');
    });
});