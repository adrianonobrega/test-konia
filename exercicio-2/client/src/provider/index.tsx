import { ReactNode } from "react";
import { ItemsProvider } from "./items";

interface ProvidersProps {
    children: ReactNode
}

export const Providers = ({children}:ProvidersProps) => {
    return (
        <ItemsProvider>
            {children}
        </ItemsProvider>
    )
}