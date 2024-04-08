var carFleet = function(target, position, speed) {
    let len = position.length;
    let map = new Map(); 
    let res = 0;
    let lastTime = -1;

    for(let i = 0; i < len; i++){
        map.set(position[i], speed[i]);
    }

    const sortedPos = [...map.keys()].sort((a, b) => b - a);
    
    for(let i = 0; i < len; i++){
        let time = (target - sortedPos[i]) / map.get(sortedPos[i]);

        if(time > lastTime){ 
            res++;
            lastTime = time;
        }
    }
    
    return res;
};