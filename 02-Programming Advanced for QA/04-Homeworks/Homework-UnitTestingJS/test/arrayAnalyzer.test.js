import { analyzeArray} from '../04-ArrayAnalizer/arrayAnalyzer.js'
import { expect } from 'chai'
import { describe } from 'mocha'

describe('ArrayAnalyser testing', () => {
    it ('should return min, max ang length value if input is valid', () => {
        let array = {
            min: 1,
            max: 10,
            length: 5
        }
        expect(analyzeArray([1, 2, 10, 7, 5]).min).to.equal(array.min);
        expect(analyzeArray([1, 2, 10, 7, 5]).max).to.equal(array.max);
        expect(analyzeArray([1, 2, 10, 7, 5]).length).to.equal(array.length);
    });
    it ('should return min, max ang length value if input is with equal elements', () => {
        let array = {
            min: 10,
            max: 10,
            length: 5
        }
        expect(analyzeArray([10, 10, 10, 10, 10]).min).to.equal(array.min);
        expect(analyzeArray([10, 10, 10, 10, 10]).max).to.equal(array.max);
        expect(analyzeArray([10, 10, 10, 10, 10]).length).to.equal(array.length);
    });
    it ('should return min, max ang length value if input is with equal elements', () => {
        let array = {
            min: 10,
            max: 10,
            length: 1
        }
        expect(analyzeArray([10]).min).to.equal(array.min);
        expect(analyzeArray([10]).max).to.equal(array.max);
        expect(analyzeArray([10]).length).to.equal(array.length);
    });
    it ('should undefined if input is empty', () => {
      expect(analyzeArray([])).to.be.undefined;
    });
    it ('should return indefined if it is nonarray', () => {
        expect(analyzeArray(undefined)).to.be.undefined;
        expect(analyzeArray('mama')).to.be.undefined;
        expect(analyzeArray(null)).to.be.undefined;
        expect(analyzeArray(5)).to.be.undefined;
        expect(analyzeArray('b')).to.be.undefined;
        expect(analyzeArray([1, 5, '3', 7])).to.be.undefined;
    });
});