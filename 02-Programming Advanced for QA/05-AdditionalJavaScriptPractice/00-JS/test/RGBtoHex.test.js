import { describe } from 'mocha';
import { expect } from 'chai';
import { rgbToHexColor } from '../RGBtoHex.js';

describe ('rgbToHexColor', () => {
    it ('return color when data is valid', () => {
        expect(rgbToHexColor(0, 0, 0)).to.be.equal("#000000");
        expect(rgbToHexColor(255, 255, 255)).to.be.equal("#FFFFFF");
    });
    it ("return undefined when data is invalid", () => {
        expect(rgbToHexColor(50, 70, 260)).to.be.undefined;
        expect(rgbToHexColor(-5, 75, 185)).to.be.undefined;
        expect(rgbToHexColor(265, "255", 255)).to.be.undefined;
        expect(rgbToHexColor(250)).to.be.undefined;
    });
});
