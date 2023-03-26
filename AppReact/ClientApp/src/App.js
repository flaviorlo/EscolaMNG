import { useState, useEffect } from "react";
import axios from 'axios';
import { Modal, ModalBody, ModalFooter, ModalHeader } from 'reactstrap';


const App = () => {

    //1: Create User State
    const baseurl = "api/Aluno/GetAllAlunos";
    const [data, setData] = useState([]);
    
    //2: call api
    
    //const alunosGet = async () => {
    //        await fetch(baseurl)
    //        .then(response => {
    //            setData(response.data);
    //        }).catch(err => {
    //            console.log(err);
    //        })
    //}

    useEffect(async () => {
       await fetch(baseurl)
            .then(response => { return response.json() })
            .then(responseJson => {
                setData(responseJson)
            })
    }, [])

    //useEffect(() => {
    //    alunosGet
    //}, [])



    return (
        <div className="Container">
            <header className="Container-header">
                <button className="btn btn-sucess">Incluir Novo Aluno</button>
            </header>
            <div className="row">
                <div className="col-sm-12">
                    <table>
                        <thead>
                            <tr>
                                <th>ID</th>
                                <th>Nome</th>
                                <th>E-mail</th>
                                <th>Idade</th>
                                <th>Operação</th>
                            </tr>
                        </thead>
                        <tbody>
                            {
                                data.map((aluno) => (
                                    <tr key={aluno.id}>
                                        <td>{aluno.id}</td>
                                        <td>{aluno.nome}</td>
                                        <td>{aluno.email}</td>
                                        <td>{aluno.idade}</td>
                                        {/*<td>*/}
                                        {/*    <button className="btn btn-primary">Editar</button>{"  "}*/}
                                        {/*    <button className="btn btn-danger">Excluir</button>*/}
                                        {/*</td>*/}
                                    </tr>
                                ))}
                        </tbody>
                    </table>
                </div>
            </div>
            
        </div>
        
        )
}

export default App;