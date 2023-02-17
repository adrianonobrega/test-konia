import { ListItem } from "../../components/ListItem"
import { Button } from "../../components/Button"
import { useState } from "react"
import { Modal } from "../../components/Modal"

export function Dashboard() {
    const [modal, setModal] = useState(false)

    function openModal() {
        setModal(true)
        console.log("oláaaa")
    }

    function closeModal() {
        setModal(false)
    }
console.log(modal,"true")
    return (
        <>

            <div className="flex flex-col h-screen">
                <h1 className="flex justify-center text-[2.5rem]">Itens do inventário</h1>
                <Button className="bg-[blue] text-center text-[white] 
                rounded-[1.25rem] h-[2.1875rem] w-[6.25rem] mb-[1.25rem] mr-[0.625rem] ml-[75rem] "
                    onClick={openModal}>+ Novo item</Button>
                {modal === true &&
                    <div className="absolute ml-[31.25rem] mt-[12.5rem] z-10 ">
                        <Modal close={closeModal} />
                    </div>
                }

                <div className=" h-[100%] display relative z-0 bg-[#dcdcdc] ">
                    <div className=" absolute border-[0.125rem] border-[white] h-[100%] ml-[8.75rem]"></div>
                    <div className=" absolute border-[0.125rem] border-[white] h-[100%] ml-[58.75rem]"></div>
                    <div className="flex justify-around  bg-[blue]">

                        <span className="ml-[-15.625rem] text-white">ID</span>
                        <span className="text-white ml-[-15.625rem]">Nome do item</span>
                        <span className="text-white">Data de criação</span>
                    </div>
                    <div className=" flex  ml-[50px] mt-[10px]">
                        <ListItem />
                    </div>
                </div>

            </div>

        </>
    )
}