import { Button } from "../Button";
import { ModalInterface } from "../../interfaces/modal";
import { useForm } from "react-hook-form";
import api from "../../services/api";
import { useContext } from "react";
import { ItemsContext } from "../../provider/items";
import { toast } from "react-toastify";

export function Modal({ close }: ModalInterface) {
    const { register, handleSubmit } = useForm()
    const { getItems } = useContext(ItemsContext);

    const submit = (name: object) => {
        api.post('items/', name)
            .then((res) => {
                getItems()
                toast.success("Item cadastrado com sucesso")
            })
            .catch((err) => console.log(err))
    }

    return (
        <>
            <div className="border-[2px] text-center bg-[#66B2FF] h-[150px] rounded-[10px]">
                <div className="float-right mr-[5px]">
                    <Button onClick={close}>X</Button>
                </div>
                <h1 className="mb-[10px] mt-[5px]">Cadastrar Item</h1>
                <form onSubmit={handleSubmit(submit)}>
                    <h2>Digite o nome do produto</h2>

                    <input type='text' {...register('name')} 
                    className="border-black border-[1px] w-[200px] mr-[30px] ml-[30px] mt-[10px] mb-[10px] rounded-[10px] " />
                    <div>
                        <Button>Cadastrar</Button>
                    </div>
                </form>



            </div>

        </>
    );
}