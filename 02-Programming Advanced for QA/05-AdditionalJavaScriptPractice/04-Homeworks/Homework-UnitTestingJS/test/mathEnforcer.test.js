import { mathEnforcer } from '../03-MathEnforcer/mathEnforcer.js'
import { expect } from 'chai'
import { describe } from 'mocha'

describe('mathEnforcer testing', () => {
    describe('add 5', () => {
        it ('should return undefined if it is not a number', () => {
            expect(mathEnforcer.addFive('5')).to.be.undefined;
            expect(mathEnforcer.addFive('m')).to.be.undefined;
            expect(mathEnforcer.addFive(null)).to.be.undefined;
            expect(mathEnforcer.addFive(undefined)).to.be.undefined;
        });
        it ('should sum with 5 and return result if it is a number', () => {
            expect(mathEnforcer.addFive(5)).to.equal(10);
            expect(mathEnforcer.addFive(-2)).to.equal(3);
            expect(mathEnforcer.addFive(1.5)).to.be.closeTo(6.5, 0.01);
        });
    });
    describe('subtract 10', () => {
        it ('should return undefined if it is not a number', () => {
            expect(mathEnforcer.subtractTen('5')).to.be.undefined;
            expect(mathEnforcer.subtractTen('m')).to.be.undefined;
            expect(mathEnforcer.subtractTen(null)).to.be.undefined;
            expect(mathEnforcer.subtractTen(undefined)).to.be.undefined;
        });
        it ('should subtract 10 and return result if it is a number', () => {
            expect(mathEnforcer.subtractTen(15)).to.equal(5);
            expect(mathEnforcer.subtractTen(-12)).to.equal(-22);
            expect(mathEnforcer.subtractTen(10.5)).to.be.closeTo(0.5, 0.01);
        });
    });
    describe('sum two numbers', () => {
        it ('should return undefined if it is not a number', () => {
            expect(mathEnforcer.sum('5', 2)).to.be.undefined;
            expect(mathEnforcer.sum('m', 2)).to.be.undefined;
            expect(mathEnforcer.sum(null, 2)).to.be.undefined;
            expect(mathEnforcer.sum(undefined, 2)).to.be.undefined;
            expect(mathEnforcer.sum(2, '5')).to.be.undefined;
            expect(mathEnforcer.sum(2, 'm')).to.be.undefined;
            expect(mathEnforcer.sum(2, null)).to.be.undefined;
            expect(mathEnforcer.sum(2, undefined)).to.be.undefined;
        });
        it ('should sum and return result if it is a number', () => {
            expect(mathEnforcer.sum(15, 5)).to.equal(20);
            expect(mathEnforcer.sum(-12, -3)).to.equal(-15);
            expect(mathEnforcer.sum(-5, 2)).to.equal(-3);
            expect(mathEnforcer.sum(5, -3)).to.equal(2);
            expect(mathEnforcer.sum(10.5, 5)).to.be.closeTo(15.5, 0.01);
            expect(mathEnforcer.sum(3, 2.5)).to.be.closeTo(5.5, 0.01);
            expect(mathEnforcer.sum(2.5, 2.5)).to.be.closeTo(5, 0.01);
            expect(mathEnforcer.sum(2.5, 2.6)).to.be.closeTo(5.1, 0.01);
            expect(mathEnforcer.sum(2.55, 2.63)).to.be.closeTo(5.18, 0.01);
        });
    });      
});