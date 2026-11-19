function PlasticTree(){
    audio.play()
}
function pauseMusic() {
    audio.pause();
}    
        
document.getElementById("playBtn").addEventListener("click", playMusic);
 document.getElementById("pauseBtn").addEventListener("click", pauseMusic);
