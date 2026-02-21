import { expect } from 'chai';
import { isSymmetric } from '../CheckForSymmetry';
import { describe } from 'mocha';

describe ("isSymetric", () => {
    describe ("return false", () => {
       it ("nonSymetricArray", () => {
        expect(isSymmetric([1, 2, 3])).to.be.false;
        expect(isSymmetric(["1", 2, "3"])).to.be.false;
        expect(isSymmetric([["1"], 2, ["3"]])).to.be.false;
        expect(isSymmetric(["a", "b", "c"])).to.be.false;

       });
       it("notArray", () => {
        expect(isSymmetric(1)).to.be.false;
        expect(isSymmetric(1, 2, 1)).to.be.false;
       });
    }),
       describe("isSymetric", () => {
        it ("symetricArray", () => {
            expect(isSymmetric([1, 2, 1])).to.be.true;
            expect(isSymmetric(["1", 2, "1"])).to.be.true;
            expect(isSymmetric([["1"], 2, ["1"]])).to.be.true;
            expect(isSymmetric(["a", "b", "a"])).to.be.true;
            expect(isSymmetric(["a", "b", "a", "a", "b", "a"])).to.be.true;
        });
    });
});
   