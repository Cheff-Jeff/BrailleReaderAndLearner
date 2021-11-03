const newLetter = document.getElementById("newLetter");
const title = document.getElementById("title");
const txt = document.getElementById("txt");
const titleArr = title.innerHTML.split('');
const txtArr = txt.innerHTML.split('');
let titleDone = false;

let letters = [
  "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", 
  "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
  ",",";",":",".","?","!","-",
];

let braille = [
  "&#10241;", //a 
  "&#10243;", //b
  "&#10249;", //c
  "&#10265;", //d
  "&#10257;", //e
  "&#10251;", //f
  "&#10267;", //g
  "&#10259;", //h
  "&#10250;", //i
  "&#10266;", //j
  "&#10245;", //k
  "&#10247;", //l
  "&#10253;", //m
  "&#10269;", //n
  "&#10261;", //o
  "&#10255;", //p
  "&#10271;", //q
  "&#10263;", //r
  "&#10254;", //s
  "&#10270;", //t
  "&#10277;", //u
  "&#10279;", //v
  "&#10298;", //w
  "&#10285;", //x
  "&#10301;", //y
  "&#10293;", //z
  "&#10242;",//,
  "&#10246;",//;
  "&#10258;",//:
  "&#10290;",//.
  "&#10274;",//?
  "&#10262;",//!
  "&#10276;",//-
]

/*
  return braille code voor een letter of teken.
*/
const getBraille = (char) => {
  char = char.toUpperCase();
  for(let i = 0; i <= letters.length; i++)
  {
    if(char == letters[i])
    {
      return braille[i];
    }
  }
  return "";
}

/*
  Zoek elke seconden naar een teken en bijbehorende braille code.
  Zet een outline om het teken.
  
*/
const read = (Arr, i) => {
  let newArr = null;
  setTimeout(() => {
    if(Arr[i] != " "){
      let newBr = getBraille(Arr[i]);
      newLetter.innerHTML = newBr;
    }else{
      newLetter.innerHTML = " ";
    }

    let newChar = Arr[i];
    newArr = [...Arr];
    newArr[i] = '<span class="outline">' + newChar + '</span>';

    let newTxt = newArr.toString();
    newTxt = newTxt.replace(/,/g,'');
    if(titleDone){
      txt.innerHTML = newTxt;   
    }
    else{
      title.innerHTML = newTxt;   
    } 

    i++
    if(i < Arr.length){
      read(Arr, i);
    }
    else{
      let newTxt = Arr.toString();
      if(titleDone){
        newTxt = newTxt.replace(/,/g,'');
        txt.innerHTML = newTxt;
        titleDone = false;
      }
      else{
        newTxt = newTxt.replace(/,/g,'');
        title.innerHTML = newTxt;
        titleDone = true;
      }
      setNewTxt();
    }
  },1000);
}

read(titleArr, 0);

/* 
  stuur tekst naar de loop.
*/
const setNewTxt = () => {
  if(!titleDone){
    read(titleArr, 0);
  }
  else{
    read(txtArr, 0);
  }
}