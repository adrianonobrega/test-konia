import React, { useEffect } from 'react';
import { ReactNode, useState } from 'react';
import { ListItemsInterface } from '../../interfaces/list';
// import { Decode } from '../../interfaces/user';
import api from '../../services/api';


interface ItemsContextValue {
    items: ListItemsInterface | undefined | any;
    setItems: (data: ListItemsInterface | undefined | any) => void;
    getItems: () => void
    dataTime: any

}

interface Props {
    children: ReactNode
}

const ItemsInitial: ItemsContextValue = {
    items:
        []
    ,
    setItems: data => { },
    getItems: () => { },
    dataTime: {},

}

export const ItemsContext = React.createContext<ItemsContextValue>(ItemsInitial)



export const ItemsProvider = ({ children }: Props) => {
    const [items, setItems] = useState(ItemsInitial.items)
    const [dataTime, setDataTime] = useState("")
    function getItems(){

        api.get('items/')
            .then((res) => {
                console.log(res.data)
                setItems(res.data)
                res.data.map((item: ListItemsInterface) => {
                    const date = item.created_at.split("T", 1).toString()
                    const dateBr = date.split("-").reverse().toString().replace(",", "/").replace(",", "/")

                    const hour = item.created_at.split("T")
                    const hourBr = hour[1].substring(0, 8)
                    const dateTime = dateBr + " " + hourBr
                    setDataTime(dateTime)
                })

            })
            .catch((err) => console.log(err))

    }
    useEffect(() => {
        getItems()
    },[])
    return (
        <ItemsContext.Provider value={{ items, setItems, getItems,dataTime }}>
            {children}
        </ItemsContext.Provider>
    );
};