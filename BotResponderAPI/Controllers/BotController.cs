using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BotResponderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private new List<string> frases = new List<string>
        {
            "A vida é sobre criar impacto, não uma renda – Kevin Kruse.",
            "Seja o que a sua mente pode conceber e acreditar, ela pode conseguir – Napoleon Hill.",
            "Esforce-se para não ser um sucesso, mas sim para ser valioso – Albert Einstein.",
            "Duas estradas divergiam em uma bifurcação, e eu peguei a menos percorrida. E isso fez toda a diferença – Robert Frost.",
            "Eu atribuo o meu sucesso a isso: eu nunca dei ou tomei qualquer desculpa – Florence Nightingale.",
            "Você perde 100% dos tiros que não dá- Wayne Gretzky.",
            "Eu perdi mais de 9 mil tiros livres em minha carreira. Eu perdi quase 300 jogos. Em 26 vezes e tive a bola do jogo e perdi. Eu falhei uma e outra vez em minha vida. E é por isso que eu consegui – Michael Jordan.",
            "A coisa mais difícil é a decisão de agir, o resto é apenas tenacidade – Amelia Earhart.",
            "Todo strike me aproxima do próximo home run – Babe Ruth.",
            "Definir um objetivo é o ponto de partida de toda a realização – W. Clement Stone.",
            "A vida não é sobre ter, e sobre dar e ser – Kevin Kruse.",
            "A vida é o que acontece com você enquanto você está ocupado fazendo planos – John Lennon.",
            "Nós nos tornamos aquilo que pensamos – Earl Nightingale.",
            "Daqui a 20 anos você estará mais decepcionado pelas coisas que você não fez, do que pelas que fez. Então, jogue fora suas amarras, navegue para longe do porto seguro, pegue os ventos em suas velas. Explore, sonha, descubra – Mark Twain.",
            "A vida é 10% do que acontece comigo e 90% de como eu reajo a isso – Charles Swindoll.",
            "A forma mais comum com que as pessoas exercem o seu poder é pensar que eles não têm poder – Alice Walker.",
            "A mente é tudo. Você se torna aquilo que você pensa – Buddha.",
            "A melhor época para plantar uma árvore foi há 20 anos. A segunda melhor é agora – Provérbio Chinês.",
            "Uma vida não examinada, não vale a pena ser vivida – Sócrates.",
            "80% do sucesso aparece – Woody Allen.",
            "Seu tempo é limitado, então não o gaste vivendo a vida de outra pessoa—Steve Jobs.",
            "Ganhar não é tudo, mas querer ganhar é – Vince Lombardi.",
            "Eu não sou um produto de minhas circunstâncias. Eu sou um produto de minhas decisões – Stephen Covey.",
            "Cada criança é um artista. O problema é permanecer um artista depois que crescemos – Pablo Picasso.",
            "Você nunca pode atravessar o oceano até que você tenha coragem de perder de vista a costa – Cristóvão Colombo.",
            "Eu aprendi que as pessoas vão esquecer o que você disse, as pessoas vão esquecer o que você fez, mas as pessoas nunca esquecerão como você as fez sentir – Maya Angelou.",
            "Ou você corre do dia, ou durante o dia você corre – Jim Rohn.",
            "Se você pensa que pode, ou que não pode, você está certo – Henry Ford.",
            "Os dias mais importantes na sua vida são o dia em que você nasce, e o dia em que você descobre o porquê – Mark Twain.",
            "Tudo que você pode fazer, ou sonha que pode, comece. Ousadia tem genialidade, poder e magia – Johann Wolfgang von Goethe.",
            "A melhor vingança é o sucesso maciço – Frank Sinatra.",
            "As pessoas costumam dizer que a motivação não dura. Bem, nem o banho. É por isso que recomendamos isso diariamente – Zig Ziglar.",
            "A vida encolhe ou expande em proporção com a sua coragem – Anais Nin.",
            "Se você ouve uma voz dentro de você dizendo ‘você não pode pintar’, então pinte e essa voz será silenciada – Vincent Van Gogh.",
            "Há apenas uma maneira de evitar críticas: não faça nada, não diga nada, e não seja nada – Aristóteles.",
            "Peça, e lhes será dado; procure e encontrará; bata, e a porta será aberta para você – Jesus.",
            "A única pessoa que você está destinado a se tornar é a pessoa que você decide ser – Ralph Waldo Emerson.",
            "Vá na direção de seus sonhos. Viva a vida que você imaginou – Henry David Thoreau.",
            "Poucas coisas podem ajudar mais um indivíduo do que colocar a responsabilidade em cima dele, e deixa-lo saber que você confia nele – Booker T. Washington.",
            "Determinadas coisas capturam o seu olho, mas leve a cabo apenas aquelas que capturam seu coração – Provérbio indiano.",
            "Acredite que você pode e você vai chegar lá – Theodore Roosevelt.",
            "Tudo o que você sempre quis está do outro ado do seu medo – George Addair.",
            "Nós podemos facilmente perdoar uma criança que tem medo do escuro; a tragédia real da vida é quando os homens têm medo da luz – Platão.",
            "Comece onde você está. Use o que você tem. Faça o que puder – Arthur Ashe.",
            "Quando eu tinha 5 anos de idade, minha mãe me disse que a felicidade era a chave para a vida. Quando eu fui para a escola, eles me perguntaram o que eu queria ser quando crescesse. Eu escrevi ‘feliz’. Eles me disseram que eu não entendi a tarefa, e eu disse a eles que eles não entendiam a vida – John Lennon.",
            "Caia 7 vezes. Levante-se 8 – Provérbio japonês.",
            "Quando a porta da felicidade se fecha, outra se abre, mas muitas vezes olhamos tanto tempo para a porta fechada que não vemos que outra foi aberta para nós – Helen Keller.",
            "Tudo tem beleza. Mas nem todos podem ver – Confúcio.",
            "Como é maravilhoso que ninguém precise esperar um momento antes de começar a melhorar o mundo – Anne Frank.",
            "Quando eu deixar de ser o que sou, eu irei me tornar o que poderia ser – Lao Tzu.",
            "A vida não é medida pelo número de respirações que damos, mas pelos momentos que nos tiram a respiração – Maya Angelou.",
            "A felicidade não é algo pronto. Ela vem de suas próprias ações – Dalai Lama.",
            "Em primeiro lugar, tenha um ideal prático e definitivo; uma meta, um objetivo. Em segundo lugar, disponha dos meios necessários para atingir os seus fins; sabedoria, dinheiro, materiais e métodos. Em terceiro lugar, ajuste todos os seus meios para esse fim – Aristóteles.",
            "Se os ventos não vão servir, leve os remos – Provérbio americano.",
            "Você não pode cair se não subir. Mas não há nenhuma alegria em viver toda a sua vida na terra – Desconhecido.",
            "Devemos crer que somos dotados de alguma coisa, e que essa coisa, deve ser atingida a qualquer custo – Marie Curie.",
            "Muitos de nós não estamos vivendo nossos sonhos porque estamos vivendo nossos medos- Les Brown.",
            "Os desafios são o que tornam a vida interessante e superá-los é o que dá sentido à vida – Joshua J. Marinho.",
            "Se você quiser se levantar, levante outra pessoa – Booker T. Washington.",
            "Fiquei impressionado com a urgência de fazer. Saber não é suficiente; devemos aplicar. Estar disposto não é o suficiente; devemos fazer – Leonardo Da Vinci.",
            "Limitações vivem apenas em nossas mentes. Mas se usarmos nossa imaginação, nossas possibilidades tornam-se ilimitadas – Jamie Paolinetti.",
            "Você toma sua vida em suas próprias mãos e o que acontece? Uma coisa terrível, ninguém para colocar a culpa – Erica Jong.",
            "O que é o dinheiro? Um homem de sucesso levanta pela manhã e vai para cama à noite. E no meio, faz o que quer fazer – Bob Dylan.",
            "Eu não falhei no teste. Eu só encontrei 100 maneiras de fazer errado – Benjamin Franklin.",
            "Para ter sucesso, o seu desejo de sucesso deve ser maior do que o seu medo do fracasso – Bill Cosby.",
            "Uma pessoa que nunca cometeu um erro, nunca tentou nada de novo – Albert Einstein.",
            "A pessoa que diz que não pode ser feito não deve interromper a pessoa que está fazendo – Provérbio chinês.",
            "Não há engarrafamentos ao longo da milha extra – Roger Staubach.",
            "Nunca é tarde demais para ser o que você poderia ter sido – George Eliot.",
            "Você se torna o que você acredita – Oprah Winfrey.",
            "Eu preferiria morrer de paixão do que de tédio – Vincent Van Gogh.",
            "Um homem verdadeiramente rico é aquele cujos filhos correm para seus braços quando suas mãos estão vazias- Autor desconhecido.",
            "Não é o que você faz para os seus filhos, mas o que você os ensinou a fazer por si mesmos, que irá torna-los serem humanos bem sucedidos – Ann Landers.",
            "Se você deseja que seus filhos acabem bem, gaste o dobro de tempo com eles, e metade do dinheiro – Abigail Van Buren.",
            "Construa seus próprios sonhos, ou alguém vai contratá-lo para construir os seus – Farrah Gray.",
            "As batalhas que contam não são apenas as medalhas de ouro. As lutas dentro de si, as batalhas invisíveis dentro de todos nós, é o que vale a pena- Jesse Owens.",
            "A educação custa dinheiro. Mas, em seguida, o mesmo acontece com a ignorância – Sir Claus Moser.",
            "Tenho aprendido ao longo dos anos que, quando a mente está pronta, isso diminui o medo – Rosa Parks.",
            "Não importa se você vai devagar, tanto quanto importa o fato de você não parar – Confúcio.",
            "Se você pode olhar para o que tem na vida, você sempre vai ter mais. Se você olhar para o que não tem, nunca terá o suficiente – Oprah Winfrey.",
            "Lembre-se que não conseguir o que você quer é algumas vezes um lance de sorte – Dalai Lama.",
            "Você não pode deixar de usar a criatividade. Quanto mais você usa, mais você tem – Maya Angelou.",
            "Sonhe grande e se atreva a falhar – Norman Vaughan.",
            "Nossas vidas começam a terminar no dia em que nos calamos sobre as coisas que importam – Martin Luther King Jr.",
            "Faça o que você puder, onde você estiver, com o que você tem – Teddy Roosevelt.",
            "Se você faz o que sempre fez, vai ter o que sempre teve – Tony Robbins.",
            "Sonhar, afinal, é uma forma de planejamento – Gloria Steinem.",
            "É o seu lugar no mundo; é a sua vida. Vá em frente e faça tudo o que puder com ela, e torne-a a vida que você quer viver – Mae Jemison.",
            "Você pode ficar desapontado se falhar, mas você está condenado se não tentar – Beverly Sills.",
            "Lembre-se que ninguém pode fazer você se sentir inferior sem o seu consentimento – Eleanor Roosevelt.",
            "A vida é o que fazemos dela, sempre foi, e sempre será – Moisés.",
            "A questão não é quem vai me deixar; mas sim, quem vai me impedir – Ayn Rand.",
            "Quando tudo parece estar indo contra você, lembre-se que o avião decola contra o vento, não a favor dele – Henry Ford.",
            "Não são os anos de sua vida que contam. É a vida em seus anos – Abraham Lincoln.",
            "Mude seus pensamentos e você muda seu mundo – Norman Vicent Peale.",
            "Escreva algo que valha a pena ler, ou faça alguma coisa que valha a pena escrever – Benjamin Franklin.",
            "Nada é impossível, a própria palavra diz ‘eu sou possível’ [i’m possible, em inglês] – Audrey Hepburn.",
            "A única maneira de fazer um excelente trabalho é amar o que você faz – Steve Jobs.",
            "Se você pode sonhar, você pode conseguir – Zig Ziglar."
        };

        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            var rand = new Random();
            return frases.ElementAt(rand.Next(frases.Count));
        }
    }
}
