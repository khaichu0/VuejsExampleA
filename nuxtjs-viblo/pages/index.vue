<template>
  <section class="container">
    <div class="content">
      <label-content
        @loadFromLocalStorage="loadFromLocalStorage"
        label="Lời chào"
      />
      <label-content @saveToLocalStorage="saveToLocalStorage" label="Cảm ơn" />
      <!-- @click="clickHandler(group,index)" -->
      <div v-for="(group, index) in groups" :key="index">
        <group-item-content
          :title="group.title"
          :group-id="group.id"
          :group-title="group.title"
          :items="group.items"
          :group-index="index"
          :active="index === activeGroup"
          :isRequired="group.isRequired"
          @changeRequired="handleGroupChangeRequired"
          @add-item="addItemToGroup(index, $event)"
          @delete-item="deleteItem"
          @delete-group="deleteGroup"
          @update-group="updateGroup"
          @activate="activateGroup(index)"

        />
      </div>
      <label-content label="Thêm thành phần" @add-row="addNewGroup" />
      <!-- <button @click="saveToLocalStorage">Save to Local Storage</button>
      <button @click="loadFromLocalStorage">Load from Local Storage</button> -->
      <!-- <v-btn color="primary">Click me!</v-btn> -->
    </div>
  </section>
</template>

<script>
import AppLogo from "~/components/AppLogo.vue";

import LabelContent from "~/components/LabelContent.vue";
import GroupItemContent from "~/components/GroupItemContent.vue";
import { v4 as uuidv4 } from "uuid";

export default {
  components: {
    AppLogo,
    LabelContent,
    GroupItemContent,
  },
  data() {
    return {
      groups: [
        // {
        //   id:uuidv4(),
        //   title: "",
        //   items: [],
        // },
      ],
      activeGroup: null,

    };
  },
  mounted() {
    this.loadFromLocalStorage();
  },
  methods: {
    addItemToGroup(index, newItem) {
      // this.groups[index].items.push(newItem);
      // debugger
      this.$router.push({
        name: "item-id",
        params: { id: newItem.id, group_item: newItem, group_index: index },
      });
    },

    addNewGroup() {
      const newGroup = {
        id: uuidv4(),
        title: "New Group",
        required:false,
        items: [],
      };
      this.groups.push(newGroup);
      this.saveToLocalStorage();
    },
    // clickHandler(item) {
    //   console.log(item);
    //   this.groupIndex = item.index;
    // },
    deleteItem(groupIndex, itemIndex) {
      this.groups[groupIndex].items.splice(itemIndex, 1);
      this.saveToLocalStorage();
    },
    deleteGroup(groupIndex) {
      if (groupIndex > 0) {
        if (window.confirm("Are you sure you want to delete this group?")) {
          this.groups.splice(groupIndex, 1);
          this.saveToLocalStorage();
        }
      } else alert("Biểu mẫu chỉ còn lại 1 thành phần");
    },
    activateGroup(index) {
      this.activeGroup = index;
    },
    saveToLocalStorage() {
      localStorage.setItem("myObject", JSON.stringify(this.groups));
    },
    loadFromLocalStorage() {
      const savedObject = localStorage.getItem("myObject");
      if (savedObject) {
        this.groups = JSON.parse(savedObject);
      }
    },
    updateGroup(groupIndex, title) {
      this.groups[groupIndex].title = title;
      this.saveToLocalStorage();
    },
    handleGroupChangeRequired(groupIndex,groupRequired){
      this.groups[groupIndex].required=groupRequired;
      console.log(this.groups[groupIndex]);
    },
  },
};
</script>

<style>
.container {
  position: relative;
  background: #f4f4f4;
}
.content {
  /* Auto layout */
  display: flex;
  flex-direction: column;
  align-items: flex-start;
  padding: 48px 423px;
  gap: 24px;
  overflow: hidden;
  position: absolute;
  max-height: calc(100vh - 130px);
  width: 100%;
  overflow: auto;
  position: absolute;
  top: 120px;
}
</style>

