import { useContext, useEffect, useState } from "react";
import api from "../../services/api";
import { ListItemsInterface } from "../../interfaces/list";
import { ItemsContext } from "../../provider/items";

export function ListItem() {

    const { items, dataTime } = useContext(ItemsContext);

    return (
        <>
            {items.map((list: ListItemsInterface) => (

                <>
                    <span className=" ">{list.id}</span>

                    <span className="ml-[320px]">{list.name}</span>

                    <span className="ml-[540px]">{dataTime}</span>
                </>

            ))}
        </>
    );
}