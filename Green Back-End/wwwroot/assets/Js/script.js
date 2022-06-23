let right = document.querySelectorAll(".right");
let left = document.querySelectorAll(".left");
let slider = document.querySelector(".sliderItem");

right.forEach(elem => {
    elem.addEventListener("click",function(){
        let active = document.querySelector(".active");
        active.classList.remove("active");
    
        if(active.nextElementSibling == null){
            console.log("null");
            slider.firstElementChild.classList.add("active");
        }
        else{
            console.log("not null");
            active.nextElementSibling.classList.add("active");
        }
    })
});
left.forEach(elem => {
    elem.addEventListener("click",function(){
        let active = document.querySelector(".active");
        active.classList.remove("active");
    
        if(active.previousElementSibling == null){
            slider.lastElementChild.classList.add("active");
        }
        else{
            active.previousElementSibling.classList.add("active");
        }
    })
})