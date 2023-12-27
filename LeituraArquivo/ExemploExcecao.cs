namespace LeituraArquivo
{
    public class ExemploExcecao
    {

        public void Metodo1(){
            try
            {
                
            Metodo2();
            }
            catch (Exception ex)
            {
            
                throw new Exception("excessao capturada na funcao 1");
            }
            
        }

           public void Metodo2(){
            Metodo3();
        }

           public void Metodo3(){
            Metodo4();
            
        }

           public void Metodo4(){
            throw new Exception("Ocorreu uma Excecao");
            
        }
        
    }
}