import { WebSocketServer } from "ws";

/*
send("asdasdasd");

1 => 2

2의 ip
172.123.15.52
2의 port
15513

int myage
int myAge
void MyAge()

wsServer = 리스닝 소켓
socket(매개변수) = 실제로 커넥션이 이루어진 소켓

리스닝 소켓:
    서버가 클라이언트를 기다려야함
    커넥션을 대기하는 소켓

    AF_FAMILY => IPv4, IPv6 기타등등
    TYPE => TCP, UDP
    STREAM => IPPROTO_TCP, TPPROTO_UDP

소켓:
    socket = accept(리스닝 소켓, ㅁㄴㅇㅁㄴㅇㅁㄴㅇ);
    socket => 실제로 클라이언트랑 통신이 되는 소켓

*/
//http://naver.com
// http://
// ws://
// socket.io
// http
// C#
// windowsocket
// linux

const port = 32000;

const wsServer = new WebSocketServer({port}, () => {
    console.log(`서버가 ${port} 에서 실행중입니다.`);
    // $"치링치링 시크릿 {gameobject.name}";
    // "치링치링 시크릿 " + gameobject.name
    // "치링치링 시크릿 쥬쥬"
});


/*
on  <= 수신
send <= 전송
똑같이 문자열만 보내짐

wsServer.on("")
            => connection : 연결이 들어오면 불림

socket.on("")
            => message : 메세지 오면 불림
            => close : 연결이 끊어지면 불림

*/

wsServer.on("connection", socket => {

    socket.on("message", data => { // data = 클라가 보내준 데이터
        console.log(data.toString());
        
    });

    
});

// 람각(상훈) 또는 람다
/*
delegate void Func();
Func a;
a = F();
a(); => F();

DOMove().OnComplete(delegate() {asdfasdf} );
DOMove().OnComplete(() => {asdfasdf} );

delegate void Func1(int a);
DOMove().OnComplete(delegate(int a) {asdfasdf} );
DOMove().OnComplete(a => {asdfasdf} );

socket.on("message", data => {

});
//noode main.js 

*/