const title = document.getElementById("title");
const txt1 = document.getElementById("txt1");
const txt2 = document.getElementById("txt2");
const newChar = document.getElementById("newChar");
const titleTxt = document.getElementById("title").innerHTML;
const txt1Txt = document.getElementById("txt1").innerHTML;
const txt2Txt = document.getElementById("txt2").innerHTML;
let focus = false;

let letters = [
  "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", 
  "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
  ",",";",":",".","?","!","-","0","1","2","3","4","5","6","7","8","9",
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
  "&#10266;",//0
  "&#10241;",//1
  "&#10243;",//2
  "&#10249;",//3
  "&#10265;",//4
  "&#10257;",//5
  "&#10251;",//6
  "&#10267;",//7
  "&#10259;",//8
  "&#10250;",//9
]

/*
  return braille code voor een letter of teken.
  oke!
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

const set = (char) => {
  const braille = getBraille(char);
  newChar.innerHTML = braille;
};

const remove = () => {
  newChar.innerHTML = "";
  focus = false;
  title.innerHTML = titleTxt;
  txt1.innerHTML = txt1Txt;
  txt2.innerHTML = txt2Txt;
}

title.addEventListener('mouseover', () => {
  if(!focus){
    focus = true;

    const letters = title.innerHTML;
    let newHTML = '';

    for(let letter of letters) {
      newHTML+="<span class='x'>"+letter+"</span>";
    }

    title.innerHTML = newHTML;

    let elm = document.getElementsByClassName('x');
    
    for(i = 0; i < elm.length; i++){
      let char = elm[i];
      elm[i].addEventListener("mouseover", () => {
        set(char.innerHTML);
      });
    }
  }
});
title.addEventListener('mouseleave', remove);

txt1.addEventListener('mouseover', () => {
  if(!focus){
    focus = true;

    const letters = txt1.innerHTML;
    let newHTML = '';

    for(let letter of letters) {
      newHTML+="<span class='x'>"+letter+"</span>";
    }

    txt1.innerHTML = newHTML;

    let elm = document.getElementsByClassName('x');
    
    for(i = 0; i < elm.length; i++){
      let char = elm[i];
      elm[i].addEventListener("mouseover", () => {
        set(char.innerHTML);
      });
    }
  }
});
txt1.addEventListener('mouseleave', remove);

txt2.addEventListener('mouseover', () => {
  if(!focus){
    focus = true;

    const letters = txt2.innerHTML;
    let newHTML = '';

    for(let letter of letters) {
      newHTML+="<span class='x'>"+letter+"</span>";
    }

    txt2.innerHTML = newHTML;

    let elm = document.getElementsByClassName('x');
    
    for(i = 0; i < elm.length; i++){
      let char = elm[i];
      elm[i].addEventListener("mouseover", () => {
        set(char.innerHTML);
      });
    }
  }
});
txt2.addEventListener('mouseleave', remove);